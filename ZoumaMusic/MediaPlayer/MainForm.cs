using MediaPlayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class MainForm : Form
    {
        

        SongsInfo currPlaySong = new SongsInfo(null);
        SongsInfo currSelectedSong = new SongsInfo(null);
        private Image currImage = Resources.defaultPicture;
        private string defaultSongsFilePath = @"C:\KwDownload\song";
        private string localSongsFilePath = Application.StartupPath + "\\songListHistory.txt";
        private string favoriteSongsFilePath = Application.StartupPath + "\\favoriteSongsHistory.txt";
        private List<SongsInfo> localSongsList = new List<SongsInfo>();                 //本地音乐List
        private List<SongsInfo> favoriteSongsList = new List<SongsInfo>();              //收藏音乐List
        private List<string[]> findSongList = new List<string[]>();
        
        
        string curTime = "00:00";
        string endTime = "00:00";

        //随机0，单曲循环1，列表循环2
        public enum PlayMode { Shuffle = 0, SingleLoop, ListLoop };
        public PlayMode currPlayMode = PlayMode.Shuffle;
        private int[] randomList;           //随机播放序列
        private int randomListIndex = 0;    //序列索引
        private int jumpSongIndex;          //手动选中需要在随机过程中跳过的歌曲
        List<MenuItem> menuItemList;

        int currIndex;   //选中的歌曲


        //序列化获得列表
        public SongListService slService = new SongListService();
        public string path= Application.StartupPath + "\\songList.xml";

        public MainForm()
        {
            InitializeComponent();
            MenuItem item1 = new MenuItem(Resources.list, "本地列表");
            MenuItem item2 = new MenuItem(Resources.favorite, "我喜欢的");

            this.menuItemList = new List<MenuItem>();
            menuItemList.Add(item1);
            menuItemList.Add(item2);

            lbMenu.Items.Add("本地列表");
            lbMenu.Items.Add("我喜欢的");

            pbAddSong.Visible = false;
            axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);

            try
            {
                slService = SongListService.Import(path);

                foreach (var sl in slService.songLists)
                {
                    menuItemList.Add(new MenuItem(Resources.list, sl.SongListName));
                    lbMenu.Items.Add(sl.SongListName);
                }
            }
            catch (Exception)
            { }
            

        }

        


        
        //设置各种初始状态
        private void Form1_Load(object sender, EventArgs e)
        {
            //设置文件打开窗口（添加音乐）可多选
            this.openFileDialog1.Multiselect = true;
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.settings.volume = 50;
            lvSongList.Visible = false;
            //重置播放器状态信息
            ReloadStatus();
            //读取播放器列表历史记录
            localSongsList = ReadHistorySongsList(localSongsFilePath);
            favoriteSongsList = ReadHistorySongsList(favoriteSongsFilePath);
            //设置专辑图片控件到顶部页面（z-index)
            lvSongList.Visible = false;
            ly1.Visible = false;
            ly2.Visible = false;
            ly3.Visible = false;
            songListPanel.BackgroundImage = Resources.defaultPicture;
        }

        private void ReloadStatus()
        {
            
            pbAlbumImage.Image = Resources.defaultPicture;
            lbTimeShow.Text = curTime+" / "+endTime;
            tkbVol.Value = tkbVol.Maximum / 2;
            axWindowsMediaPlayer1.settings.volume = 50;
            tkbMove.Value = 0;
            if (lvSongList.Items.Count > 0 && lvSongList.SelectedItems.Count == 0)
            {
                lvSongList.Items[0].Selected = true;           
                lvSongList.Items[0].EnsureVisible();
                lvSongList.Items[0].Focused = true;
            }
        }

        /*
          和左边列表有关的函数
        */
        private void lbMenu_DrawItem(object sender, DrawItemEventArgs e)
        {
            Bitmap bitmap = new Bitmap(e.Bounds.Width, e.Bounds.Height);

            int index = e.Index;                                //获取当前要进行绘制的行的序号，从0开始。
            Graphics g = e.Graphics;                            //获取Graphics对象。

            Graphics tempG = Graphics.FromImage(bitmap);

            tempG.SmoothingMode = SmoothingMode.AntiAlias;          //使绘图质量最高，即消除锯齿
            tempG.InterpolationMode = InterpolationMode.HighQualityBicubic;
            tempG.CompositingQuality = CompositingQuality.HighQuality;

            Rectangle bound = e.Bounds;                         //获取当前要绘制的行的一个矩形范围。
            string text = this.menuItemList[index].Text.ToString();     //获取当前要绘制的行的显示文本。

            Color backgroundColor = Color.FromArgb(34, 35, 39);             //背景色
            Color guideTagColor = Color.FromArgb(183, 218, 114);            //高亮指示色
            Color selectedBackgroundColor = Color.FromArgb(46, 47, 51);     //选中背景色
            Color fontColor = Color.Gray;                                   //字体颜色
            Color selectedFontColor = Color.White;                          //选中字体颜色
            Font textFont = new Font("微软雅黑", 9, FontStyle.Bold);        //文字
            //图标
            Image itmeImage = this.menuItemList[index].Img;
            //矩形大小
            Rectangle backgroundRect = new Rectangle(0, 0, bound.Width, bound.Height);
            Rectangle guideRect = new Rectangle(0, 4, 5, bound.Height - 8);
            Rectangle textRect = new Rectangle(55, 0, bound.Width, bound.Height);
            Rectangle imgRect = new Rectangle(20, 4, 22, bound.Height - 8);
            //当前选中行
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                backgroundColor = selectedBackgroundColor;
                fontColor = selectedFontColor;
            }
            else
            {
                guideTagColor = backgroundColor;
            }
            //绘制背景色
            tempG.FillRectangle(new SolidBrush(backgroundColor), backgroundRect);
            //绘制左前高亮指示
            tempG.FillRectangle(new SolidBrush(guideTagColor), guideRect);
            //绘制显示文本
            TextRenderer.DrawText(tempG, text, textFont, textRect, fontColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            //绘制图标
            tempG.DrawImage(itmeImage, imgRect);
            g.DrawImage(bitmap, bound.X, bound.Y, bitmap.Width, bitmap.Height);
            tempG.Dispose();
        }

        private void lbMenu_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 30;
        }

        private void lbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvSongList.Visible=true;
            ly1.Visible = false;
            ly2.Visible = false;
            ly3.Visible = false;
            if(lbMenu.SelectedIndex==0)
            {
                lvSongList.Items.Clear();
                AddSongsToListView(localSongsList);
                pbAddSong.Visible = true;
                lbCategory.Text = "本地音乐";
                lbCategory.Visible = true;
                lbSongCount.Visible = true;
                tsmiDelete.Visible = true;
                tsmiFavorite.Visible = true;
                tsmiPlay.Visible = true;
                tsmiDownload.Visible = false;
                tsmiAddSongs.Visible = false;
                tsmiDeleteSongList.Visible = false;
            }
            else if(lbMenu.SelectedIndex==1)
            {
                lvSongList.Items.Clear();
                AddSongsToListView(favoriteSongsList);
                pbAddSong.Visible = false;
                lbCategory.Text = "收藏音乐";
                lbCategory.Visible = true;
                lbSongCount.Visible = true;
                tsmiFavorite.Visible = false;
                tsmiDelete.Visible = true;
                tsmiPlay.Visible = true;
                tsmiDownload.Visible = false;
                tsmiAddSongs.Visible = false;
                tsmiDeleteSongList.Visible = false;
            }
            else if(lbMenu.SelectedIndex<slService.songLists.Count+2)
            {
                lvSongList.Items.Clear();
                AddSongsToListView(slService.songLists[lbMenu.SelectedIndex - 2].Songs);
                pbAddSong.Visible = false;
                lbCategory.Text = slService.songLists[lbMenu.SelectedIndex - 2].SongListName;
                lbCategory.Visible = true;
                lbSongCount.Visible = true;
                tsmiDelete.Visible = true;
                tsmiFavorite.Visible = true;
                tsmiPlay.Visible = true;
                tsmiDownload.Visible = false;
                tsmiAddSongs.Visible = true;
                tsmiDeleteSongList.Visible = true;
            }
            int songsCount = lvSongList.Items.Count;
            lbSongCount.Text = songsCount + "首音乐";
        }

        /*
        * 关闭、最大化、最小化按钮点击事件
        */
        private void FormControlButton_Click(object sender, EventArgs e)
        {
            PictureBox currPicBox = (PictureBox)sender;
            if (currPicBox.Name == "pbClose")
            {
                this.Close();
            }
            else if (currPicBox.Name == "pbMax")
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                    currPicBox.Image = Resources._222;
                }
                else if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                    currPicBox.Image = Resources._22;
                }

                else this.WindowState = FormWindowState.Maximized;
            }
            else if (currPicBox.Name == "pbMin")
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        /*
         * 拖动窗口，标题文字拖动变色（默认gray、拖动white）
         */
        Point downPoint;
        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            downPoint = new Point(e.X, e.Y);
            TitleLabel.ForeColor = Color.White;
        }
        private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - downPoint.X, this.Location.Y + e.Y - downPoint.Y);
            }
        }
        private void TitleLabel_MouseUp(object sender, MouseEventArgs e)
        {
            TitleLabel.ForeColor = Color.Gray;
        }

        /*
         * 播放列表重绘
         */
        private void lvSongList_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            int index = e.ColumnIndex;

            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(27, 27, 25)), e.Bounds);
            TextRenderer.DrawText(e.Graphics, lvSongList.Columns[index].Text, new Font("微软雅黑", 9, FontStyle.Regular), e.Bounds, Color.Gray, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);

            Pen pen = new Pen(Color.FromArgb(34, 35, 39), 2);
            Point p = new Point(e.Bounds.Left - 1, e.Bounds.Top + 1);
            Size s = new Size(e.Bounds.Width, e.Bounds.Height - 2);
            Rectangle r = new Rectangle(p, s);
            e.Graphics.DrawRectangle(pen, r);
        }
        private void lvSongList_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            Console.WriteLine("selectedCount:" + lvSongList.SelectedItems.Count);
            if (e.ItemIndex == -1)
            {
                return;
            }

            if (e.ItemIndex % 2 == 0)
            {
                e.SubItem.BackColor = Color.FromArgb(27, 29, 32);
                e.DrawBackground();
            }

            if (e.ColumnIndex == 1)
            {
                e.SubItem.ForeColor = Color.White;
            }
            else
            {
                e.SubItem.ForeColor = Color.Gray;
            }

            if ((e.ItemState & ListViewItemStates.Selected) == ListViewItemStates.Selected)
            {
                using (SolidBrush brush = new SolidBrush(Color.Blue))
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(46, 47, 51)), e.Bounds);
                }
            }

            if (!string.IsNullOrEmpty(e.SubItem.Text))
            {
                this.DrawText(e, e.Graphics, e.Bounds, 2);
            }
        }
        private void DrawText(DrawListViewSubItemEventArgs e, Graphics g, Rectangle r, int paddingLeft)
        {
            TextFormatFlags flags = GetFormatFlags(e.Header.TextAlign);

            r.X += 1 + paddingLeft;//重绘图标时，文本右移
            TextRenderer.DrawText(
                g,
                e.SubItem.Text,
                e.SubItem.Font,
                r,
                e.SubItem.ForeColor,
                flags);
        }
        private TextFormatFlags GetFormatFlags(HorizontalAlignment align)
        {
            TextFormatFlags flags =
                    TextFormatFlags.EndEllipsis |
                    TextFormatFlags.VerticalCenter;

            switch (align)
            {
                case HorizontalAlignment.Center:
                    flags |= TextFormatFlags.HorizontalCenter;
                    break;
                case HorizontalAlignment.Right:
                    flags |= TextFormatFlags.Right;
                    break;
                case HorizontalAlignment.Left:
                    flags |= TextFormatFlags.Left;
                    break;
            }

            return flags;
        }

        //本地文件操作
        private void tsmiOpenFile_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = defaultSongsFilePath;
            this.openFileDialog1.Filter = "媒体文件|*.mp3;*.wav;*.wma;*.avi;*.mpg;*.asf;*.wmv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    string path = openFileDialog1.FileNames[i];
                    if (!IsExistInLocalList(path))
                        localSongsList.Add(new SongsInfo(path));
                }
            }

            AddSongsToListView(localSongsList);
            SaveSongsListHistory(localSongsFilePath, localSongsList);
        }

        private bool IsExistInLocalList(string path)
        {
            for (int i = 0; i < localSongsList.Count; i++)
            {
                if (path == localSongsList[i].FilePath)
                    return true;
            }
            return false;
        }

        //列表显示
        private void AddSongsToListView(List<SongsInfo> songList)
        {
            lvSongList.BeginUpdate();
            lvSongList.Items.Clear();
            foreach (SongsInfo song in songList)
            {
                string[] songAry = new string[5];
                int currCount = lvSongList.Items.Count + 1;
                if (currCount < 10)
                    songAry[0] = "0" + currCount;
                else
                    songAry[0] = "" + currCount;

                int n = song.FileName.IndexOf('-');
                songAry[1] = song.FileName.Substring(0, n);
                songAry[2] = song.FileName.Substring(n + 1, song.FileName.Length - 1 - n);
                songAry[3] = song.Duration;
                songAry[4] = song.Filesize;


                ListViewItem lvItem = new ListViewItem(songAry);
                lvItem.SubItems.Add(song.FilePath);
                lvSongList.Items.Add(lvItem);

                WMPLib.IWMPMedia media = axWindowsMediaPlayer1.newMedia(song.FilePath);
                axWindowsMediaPlayer1.currentPlaylist.appendItem(media);
            }
            lvSongList.EndUpdate();
        }

        
       //保存历史记录到本地文件
        private void SaveSongsListHistory(string savePath, List<SongsInfo> songsList)
        {
            string saveString = "";
            for (int i = 0; i < songsList.Count; i++)
            {
                saveString += songsList[i].FilePath + "};{";
            }
            File.WriteAllText(savePath, saveString);
        }

       
        //读取历史记录到本地文件
        private List<SongsInfo> ReadHistorySongsList(string filePath)
        {
            List<SongsInfo> resSongList = new List<SongsInfo>();
            string readString = "";
            if (File.Exists(filePath))
            {
                readString = File.ReadAllText(filePath);
                if (readString != "")
                {
                    string[] arr = readString.Split(new string[] { "};{" }, StringSplitOptions.None);
                    foreach (string path in arr)
                    {
                        if (path != null && path != "" && File.Exists(path))
                        {
                            resSongList.Add(new SongsInfo(path));
                        }
                    }
                }
            }
            else
                File.Create(filePath);

            return resSongList;
        }


        private void Play(int index)
        {
            //设置被播放音乐项的状态
            lvSongList.Items[index].Focused = true;
            lvSongList.Items[index].EnsureVisible();
            //lvSongList.Items[index].Selected = true;
            //string path = "D:\\MySong\\Detail\\" + currPlaySong.FileName + ".lrc";
            //Lyrics.ReadLrc(path);

            if (axWindowsMediaPlayer1.playState.ToString() == "wmppsPlaying")       //播放->其他状态
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                pbPlay.Image = Resources.播放;
                return;
            }
            else if (axWindowsMediaPlayer1.playState.ToString() != "wmppsPaused")      //更改播放路径并播放
            {
                //生成随机序列
                BuildRandomList(lvSongList.Items.Count);
                jumpSongIndex = index;
                currPlaySong = new SongsInfo(lvSongList.SelectedItems[0].SubItems[5].Text);
                axWindowsMediaPlayer1.URL = currPlaySong.FilePath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                //string path = "D:\\MySong\\Detail\\" + currPlaySong.FileName + ".lrc";
                //Lyrics.ReadLrc(path);
                return;
            }
            else
            //暂停->播放
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                //string path = "D:\\MySong\\Detail\\" + currPlaySong.FileName + ".lrc";
                //Lyrics.ReadLrc(path);
            }
                
       

            pbPlay.Image = Resources.暂停;

        }

        private string GetPath()
        {
            try
            {
                currIndex = lvSongList.SelectedItems[0].Index;
            }
            catch (ArgumentOutOfRangeException) { }
            switch (currPlayMode)
            {
                case PlayMode.ListLoop:
                    if (currIndex != lvSongList.Items.Count - 1)
                        currIndex += 1;
                    else
                        currIndex = 0;

                    break;
                case PlayMode.SingleLoop:
                    Console.WriteLine("SingleLoop");

                    break;
                case PlayMode.Shuffle:
                    //当局结束
                    if (randomListIndex > randomList.Length - 1)
                        StarNewRound();

                    //匹配到需要跳过的歌曲
                    if (randomList[randomListIndex] == jumpSongIndex)
                        if (randomListIndex == randomList.Length - 1)   //当局结束
                            StarNewRound();
                        else
                            randomListIndex++;

                    currIndex = randomList[randomListIndex++];

                    break;
            }

            lvSongList.Items[currIndex].Selected = true;//设定选中            
            lvSongList.Items[currIndex].EnsureVisible();//保证可见
            lvSongList.Items[currIndex].Focused = true;
            currPlaySong = new SongsInfo(lvSongList.SelectedItems[0].SubItems[5].Text);

            return currPlaySong.FilePath;
        }

        private void StarNewRound()
        {
            //重新生成随机序列
            BuildRandomList(lvSongList.Items.Count);
            //第二轮开始 播放所有歌曲 不跳过
            jumpSongIndex = -1;
        }

        private void BuildRandomList(int songListCount)
        {
            randomListIndex = 0;
            randomList = new int[songListCount];

            //初始化序列
            for (int i = 0; i < songListCount; i++)
            {
                randomList[i] = i;
            }

            //随机序列
            for (int i = songListCount - 1; i >= 0; i--)
            {
                Random r = new Random(Guid.NewGuid().GetHashCode());
                int j = r.Next(0, songListCount - 1);
                swap(randomList, i, j);
            }
        }

        private void swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }


        //播放器控件状态改变事件
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (e.newState)
            {
                case 0:    // 未知状态
                    break;

                case 1:    // Stopped 停止
                    timer.Stop();
                    ReloadStatus();
                    break;

                case 2:    // Paused 暂停
                    timer.Stop();
                    break;

                case 3:    // Playing 正在播放
                    timer.Start();
                    //显示专辑图片
                    int n = currPlaySong.FilePath.IndexOf('.');
                    int m = currPlaySong.FileName.LastIndexOf('\\');

                    string path = "D:\\MySong\\Detail\\" + currPlaySong.FileName + ".jpg";
                    currImage = Image.FromFile(path);
                    songListPanel.BackgroundImage = currImage;
                    pbAlbumImage.Image = currImage;

                    string path1 = "D:\\MySong\\Detail\\" + currPlaySong.FileName + ".lrc";
                    Lyrics.ReadLrc(path1);

                    //显示歌曲标题名字
                    lbSongName.Text = currPlaySong.FileName;
                    
                    tkbMove.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;
                    //解决不选中歌曲的问题
                    try
                    {    
                        currIndex = lvSongList.SelectedItems[0].Index;
                        lvSongList.SelectedItems.Clear();
                        lvSongList.Items[currIndex].Selected = true;    //设定选中            
                        lvSongList.Items[currIndex].EnsureVisible();    //保证可见
                        lvSongList.Items[currIndex].Focused = true;
                        lvSongList.Select();
                    }
                    catch(ArgumentOutOfRangeException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                    break;
            }

            if (axWindowsMediaPlayer1.playState.ToString() == "wmppsMediaEnded")
            {
                //获取音乐播放文件路径，并添加到播放控件
                string path = GetPath();
                WMPLib.IWMPMedia media = axWindowsMediaPlayer1.newMedia(path);
                axWindowsMediaPlayer1.currentPlaylist.appendItem(media);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (lvSongList.Items.Count == 0)
            {
                MessageBox.Show("请先添加曲目至目录");
                return;
            }
            if (axWindowsMediaPlayer1.playState.ToString() == "wmppsPlaying")       //播放->暂停
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                pbPlay.Image = Resources.播放;
                return;
            }
            else if (axWindowsMediaPlayer1.playState.ToString() == "wmppsPaused")    //暂停->播放
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pbPlay.Image = Resources.暂停;
                return;
            }
            else
            {
                pbPlay.Image = Resources.暂停;
            }
            if (lvSongList.SelectedItems.Count > 0)         //双击播放列表控制
            {
                Play(lvSongList.SelectedItems[0].Index);
            }
            else
                MessageBox.Show("请选择要播放的曲目");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (lvSongList.Items.Count == 0)
            {
                MessageBox.Show("请先添加曲目至目录");
                return;
            }
            try
            {
                currIndex = lvSongList.SelectedItems[0].Index;
            }
            catch (ArgumentOutOfRangeException) { }
            if (currIndex > 0)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                currIndex -= 1;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                currIndex = lvSongList.Items.Count - 1;
            }
            pbPlay.Image = Resources.暂停;
            lvSongList.Items[currIndex].Focused = true;
            lvSongList.Items[currIndex].EnsureVisible();
            lvSongList.Items[currIndex].Selected = true;

            Play(currIndex);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lvSongList.Items.Count == 0)
            {
                MessageBox.Show("请先添加曲目至目录");
                return;
            }
            try
            {
                currIndex = lvSongList.SelectedItems[0].Index;
            }
            catch (ArgumentOutOfRangeException) { }
            if (currIndex < lvSongList.Items.Count - 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                currIndex += 1;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                currIndex = 0;
            }
            pbPlay.Image = Resources.暂停;
            lvSongList.Items[currIndex].Focused = true;
            lvSongList.Items[currIndex].EnsureVisible();
            lvSongList.Items[currIndex].Selected = true;
            Play(currIndex);
        }

        private void btnPlayMode_Click(object sender, EventArgs e)
        {
            if (currPlayMode == PlayMode.ListLoop)
                currPlayMode = PlayMode.Shuffle;
            else
                currPlayMode += 1;

            if (currPlayMode == PlayMode.SingleLoop)
                btnPlayMode.Image = Properties.Resources.单曲循环;
            else if (currPlayMode == PlayMode.ListLoop)
                btnPlayMode.Image = Properties.Resources.列表循环;
            else
                btnPlayMode.Image = Properties.Resources.随机播放;
        }

        private void tkbMove_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = (double)this.tkbMove.Value;
        }


        //计时器函数
        private void timer_Tick(object sender, EventArgs e)
        {
            //设置当前播放时间
            curTime = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            endTime = currPlaySong.Duration.Remove(0, 3);
            lbTimeShow.Text = curTime + " / " + endTime;
            //设置滑动条值
            tkbMove.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            int icurTime;
            try
            {
                icurTime = Int32.Parse(curTime.Substring(0, 2)) * 60 + Int32.Parse(curTime.Substring(3, 2));
                for (int i = 0; i < Lyrics.cnt; i++)
                {

                    if (i == Lyrics.cnt - 1)
                    {
                        this.ly1.Text = Lyrics.lyrics[i - 1];
                        this.ly2.Text = Lyrics.lyrics[i];
                        //this.ly3.Text = Lyrics.lyrics[i+1];
                    }
                    else if (((int)Lyrics.times[i + 1]) > icurTime)
                    {
                        if (i > 0) this.ly1.Text = Lyrics.lyrics[i - 1];
                        this.ly2.Text = Lyrics.lyrics[i];
                        this.ly3.Text = Lyrics.lyrics[i+1];
                        return;
                    }
                }
            
            }
            catch (Exception) { }
        }

        //播放列表双击事件
        private void lvSongList_DoubleClick(object sender, EventArgs e)
        {
            Console.WriteLine(lvSongList.SelectedItems[0].Index);

            int currIndex = lvSongList.SelectedItems[0].Index;
            string songFilePath = lvSongList.Items[currIndex].SubItems[5].Text;
            if (currPlaySong.FilePath == songFilePath)
            {
                //选中歌曲为正在播放的歌曲
                if (axWindowsMediaPlayer1.playState.ToString() == "wmppsPlaying")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                    pbPlay.Image = Resources.播放;
                }
                else if (axWindowsMediaPlayer1.playState.ToString() == "wmppsPaused")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    pbPlay.Image = Resources.暂停;
                }
            }
            else
            {
                //选中的为其他歌曲
                BuildRandomList(lvSongList.Items.Count);
                jumpSongIndex = currIndex;
                currPlaySong = new SongsInfo(songFilePath);
                axWindowsMediaPlayer1.URL = songFilePath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pbPlay.Image = Resources.暂停;
            }
            lvSongList.Items[currIndex].Focused = true;
        }

        private void tsmiFavorite_Click(object sender, EventArgs e)
        {
            foreach (SongsInfo song in favoriteSongsList)
            {
                if (currSelectedSong.FilePath == song.FilePath)
                {
                    MessageBox.Show("该歌曲已经在收藏列表了");
                    return;
                }      
            }
            favoriteSongsList.Add(new SongsInfo(currSelectedSong.FilePath));
            SaveSongsListHistory(favoriteSongsFilePath, favoriteSongsList);
            MessageBox.Show("添加成功");
        }

        private void tsmiPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            currIndex = lvSongList.SelectedItems[0].Index;
            Play(currIndex);
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            int removeIndex = lvSongList.SelectedItems[0].Index;
            if (lbMenu.SelectedIndex == 0)
            {
                localSongsList.RemoveAt(removeIndex);
                SaveSongsListHistory(localSongsFilePath, localSongsList);
                AddSongsToListView(localSongsList);
            }
            else if (lbMenu.SelectedIndex == 1)
            {
                favoriteSongsList.RemoveAt(removeIndex);
                SaveSongsListHistory(favoriteSongsFilePath, favoriteSongsList);
                AddSongsToListView(favoriteSongsList);
            }
            else
            {
                slService.songLists[lbMenu.SelectedIndex - 2].Songs.RemoveAt(removeIndex);
                AddSongsToListView(slService.songLists[lbMenu.SelectedIndex - 2].Songs);
                slService.Export(path);
            }
                

        }

        private void lvSongList_RightMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = lvSongList.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    cmslvList.Visible = true;
                    currSelectedSong = new SongsInfo(item.SubItems[5].Text);
                    cmslvList.Show(Cursor.Position);
                }
                else
                    cmslvList.Close();
            }
        }

        private void tkbVol_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = this.tkbVol.Value;
        }

        private void FindSongsInLocalToListView(List<string[]> searchedSongs)
        {
            lvSongList.BeginUpdate();
            lvSongList.Items.Clear();
            foreach (string[] song in searchedSongs)
            {
                string[] songAry = new string[5];
                int currCount = lvSongList.Items.Count + 1;
                if (currCount < 10)
                    songAry[0] = "0" + currCount;
                else
                    songAry[0] = "" + currCount;

                songAry[1] = song[1];
                songAry[2] = song[2];
                songAry[3] = "未知";
                songAry[4] = "未知";


                ListViewItem lvItem = new ListViewItem(songAry);
                lvItem.SubItems.Add(song[1]);
                lvSongList.Items.Add(lvItem);
            }
            lvSongList.EndUpdate();
        }

        private void tbSearchKey_Enter(object sender, EventArgs e)
        {
            if (tbSearchKey.Text == "请输入要搜索的关键字")
                tbSearchKey.Text = "";
        }

        private void tbSearchKey_Leave(object sender, EventArgs e)
        {
            if (tbSearchKey.Text == "")
                tbSearchKey.Text = "请输入要搜索的关键字";
        }

        //搜索图标  
        private void pbSearch_Click(object sender, EventArgs e)
        {
            lbCategory.Text = "搜索音乐";
            pbAddSong.Visible = false;
            tsmiDelete.Visible = false;
            tsmiFavorite.Visible = false;
            tsmiPlay.Visible = false;
            tsmiDownload.Visible = true;
            findSongList = GetSong.GetSongList(tbSearchKey.Text);
            FindSongsInLocalToListView(findSongList);
            lbSongCount.Text = findSongList.Count + "首音乐";
        }


        //下载音乐
        private void tsmiDownload_Click(object sender, EventArgs e)
        {
            int curSelectedIndex = lvSongList.SelectedItems[0].Index;
            string[] item = findSongList[curSelectedIndex];
            GetSong.HttpDownloadMp3(item, @"D:\\MySong\\Music");
            GetSong.HttpDownloadLrc(item, @"D:\\MySong\\Detail");
            GetSong.HttpDownloadPic(item, @"D:\\MySong\\Detail");

        }

        private void pbAlbumImage_Click(object sender, EventArgs e)
        {
            ly1.Visible = true;
            ly2.Visible = true;
            ly3.Visible = true;
            lvSongList.Visible = false;
            pbAddSong.Visible = false;
            lbSongCount.Visible = false;
        }


        private void ListsReLoad()
        {
            slService.Export(path);
            lbMenu.BeginUpdate();
            lbMenu.Items.Clear();
            menuItemList.RemoveAll(it => menuItemList.IndexOf(it) > 1);
            slService = SongListService.Import(path);
            foreach (var sl in slService.songLists)
            {
                menuItemList.Add(new MenuItem(Resources.list, sl.SongListName));
            }
            foreach (var mi in menuItemList)
            {
                lbMenu.Items.Add(mi);
            }
            lbMenu.EndUpdate();
        }

        private void pbAddList_Click(object sender, EventArgs e)
        {
            slService.AddList("新建列表");
            ListsReLoad();

        }

        private void tsmiDeleteSongList_Click(object sender, EventArgs e)
        {
            int removeIndex = lbMenu.SelectedIndex;
            if (lbMenu.SelectedIndex > 1)
            {
                slService.songLists.RemoveAt(removeIndex-2);
                ListsReLoad();
            }
            
        }

        private void tsmiAddSongs_Click(object sender, EventArgs e)
        {
            int selectIndex = lbMenu.SelectedIndex;
            this.openFileDialog1.InitialDirectory = defaultSongsFilePath;
            this.openFileDialog1.Filter = "媒体文件|*.mp3;*.wav;*.wma;*.avi;*.mpg;*.asf;*.wmv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    string path = openFileDialog1.FileNames[i];
                    if (!slService.songLists[selectIndex - 2].Songs.Exists(song => song.FilePath == path))
                        slService.songLists[selectIndex - 2].Songs.Add(new SongsInfo(path));
                    else MessageBox.Show("该歌曲已经在播放列表了");
                }
            }
            AddSongsToListView(slService.songLists[selectIndex-2].Songs);
            slService.Export(path);
        }

        private void MoveEnter_ChangeIconToHooverStyle(object sender, EventArgs e)
        {
            PictureBox currPicBox = (PictureBox)sender;
            if (currPicBox.Name == "pbAlbumImage")
                pbAlbumImage.Image = Resources.展开;

        }

        private void MoveLeave_ChangeIconToHooverStyle(object sender, EventArgs e)
        {
            PictureBox currPicBox = (PictureBox)sender;
            if (currPicBox.Name == "pbAlbumImage")
                pbAlbumImage.Image = currImage;

        }
        
    }
}
