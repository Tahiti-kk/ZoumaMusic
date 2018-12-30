namespace MediaPlayer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ControlBarPanel = new System.Windows.Forms.Panel();
            this.tkbVol = new System.Windows.Forms.TrackBar();
            this.lbTimeShow = new System.Windows.Forms.Label();
            this.lbSongName = new System.Windows.Forms.Label();
            this.tkbMove = new System.Windows.Forms.TrackBar();
            this.ListPanel = new System.Windows.Forms.Panel();
            this.lbMenu = new System.Windows.Forms.ListBox();
            this.cmsSongList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.WindowPanel = new System.Windows.Forms.Panel();
            this.ListTitlePanel = new System.Windows.Forms.Panel();
            this.lbSongCount = new System.Windows.Forms.Label();
            this.tbSearchKey = new System.Windows.Forms.TextBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cmslvList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.songListPanel = new System.Windows.Forms.Panel();
            this.ly3 = new System.Windows.Forms.Label();
            this.ly2 = new System.Windows.Forms.Label();
            this.ly1 = new System.Windows.Forms.Label();
            this.lvSongList = new System.Windows.Forms.ListView();
            this.colNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSinger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbAddSong = new System.Windows.Forms.PictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.tsmiDeleteSongList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddSongs = new System.Windows.Forms.ToolStripMenuItem();
            this.pbAddList = new System.Windows.Forms.PictureBox();
            this.pbVolume = new System.Windows.Forms.PictureBox();
            this.btnPlayMode = new System.Windows.Forms.PictureBox();
            this.pbAlbumImage = new System.Windows.Forms.PictureBox();
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbMin = new System.Windows.Forms.PictureBox();
            this.pbMax = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.tsmiPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFavorite = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.TitlePanel.SuspendLayout();
            this.ControlBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbMove)).BeginInit();
            this.ListPanel.SuspendLayout();
            this.cmsSongList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.WindowPanel.SuspendLayout();
            this.ListTitlePanel.SuspendLayout();
            this.cmslvList.SuspendLayout();
            this.songListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.TitlePanel.Controls.Add(this.pbMin);
            this.TitlePanel.Controls.Add(this.pbMax);
            this.TitlePanel.Controls.Add(this.pbClose);
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(874, 31);
            this.TitlePanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Gray;
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(874, 31);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Music Player";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseMove);
            this.TitleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseUp);
            // 
            // ControlBarPanel
            // 
            this.ControlBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ControlBarPanel.Controls.Add(this.tkbVol);
            this.ControlBarPanel.Controls.Add(this.pbVolume);
            this.ControlBarPanel.Controls.Add(this.btnPlayMode);
            this.ControlBarPanel.Controls.Add(this.lbTimeShow);
            this.ControlBarPanel.Controls.Add(this.lbSongName);
            this.ControlBarPanel.Controls.Add(this.pbAlbumImage);
            this.ControlBarPanel.Controls.Add(this.tkbMove);
            this.ControlBarPanel.Controls.Add(this.pbPlay);
            this.ControlBarPanel.Controls.Add(this.pbNext);
            this.ControlBarPanel.Controls.Add(this.pbBack);
            this.ControlBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlBarPanel.Location = new System.Drawing.Point(0, 538);
            this.ControlBarPanel.Name = "ControlBarPanel";
            this.ControlBarPanel.Size = new System.Drawing.Size(874, 75);
            this.ControlBarPanel.TabIndex = 1;
            // 
            // tkbVol
            // 
            this.tkbVol.AutoSize = false;
            this.tkbVol.Location = new System.Drawing.Point(772, 31);
            this.tkbVol.Maximum = 100;
            this.tkbVol.Name = "tkbVol";
            this.tkbVol.Size = new System.Drawing.Size(99, 29);
            this.tkbVol.TabIndex = 10;
            this.tkbVol.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tkbVol.Scroll += new System.EventHandler(this.tkbVol_Scroll);
            // 
            // lbTimeShow
            // 
            this.lbTimeShow.AutoSize = true;
            this.lbTimeShow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTimeShow.ForeColor = System.Drawing.Color.White;
            this.lbTimeShow.Location = new System.Drawing.Point(600, 12);
            this.lbTimeShow.Name = "lbTimeShow";
            this.lbTimeShow.Size = new System.Drawing.Size(83, 17);
            this.lbTimeShow.TabIndex = 5;
            this.lbTimeShow.Text = "00:00 / 00:00";
            // 
            // lbSongName
            // 
            this.lbSongName.AutoSize = true;
            this.lbSongName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSongName.ForeColor = System.Drawing.Color.White;
            this.lbSongName.Location = new System.Drawing.Point(273, 12);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(0, 17);
            this.lbSongName.TabIndex = 4;
            // 
            // tkbMove
            // 
            this.tkbMove.AutoSize = false;
            this.tkbMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.tkbMove.Location = new System.Drawing.Point(261, 35);
            this.tkbMove.Maximum = 100;
            this.tkbMove.Name = "tkbMove";
            this.tkbMove.Size = new System.Drawing.Size(429, 34);
            this.tkbMove.TabIndex = 3;
            this.tkbMove.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tkbMove.Scroll += new System.EventHandler(this.tkbMove_Scroll);
            // 
            // ListPanel
            // 
            this.ListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ListPanel.Controls.Add(this.lbMenu);
            this.ListPanel.Controls.Add(this.panel1);
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListPanel.Location = new System.Drawing.Point(0, 31);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(252, 507);
            this.ListPanel.TabIndex = 0;
            // 
            // lbMenu
            // 
            this.lbMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lbMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMenu.ContextMenuStrip = this.cmsSongList;
            this.lbMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMenu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbMenu.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMenu.ForeColor = System.Drawing.Color.White;
            this.lbMenu.FormattingEnabled = true;
            this.lbMenu.Location = new System.Drawing.Point(0, 38);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(252, 469);
            this.lbMenu.TabIndex = 1;
            this.lbMenu.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbMenu_DrawItem);
            this.lbMenu.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lbMenu_MeasureItem);
            this.lbMenu.SelectedIndexChanged += new System.EventHandler(this.lbMenu_SelectedIndexChanged);
            // 
            // cmsSongList
            // 
            this.cmsSongList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmsSongList.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmsSongList.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsSongList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteSongList,
            this.tsmiAddSongs});
            this.cmsSongList.Name = "cmsSongList";
            this.cmsSongList.Size = new System.Drawing.Size(143, 64);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbAddList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "列表";
            // 
            // WindowPanel
            // 
            this.WindowPanel.AutoSize = true;
            this.WindowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WindowPanel.Controls.Add(this.songListPanel);
            this.WindowPanel.Controls.Add(this.ListTitlePanel);
            this.WindowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowPanel.Location = new System.Drawing.Point(252, 31);
            this.WindowPanel.Name = "WindowPanel";
            this.WindowPanel.Size = new System.Drawing.Size(622, 507);
            this.WindowPanel.TabIndex = 2;
            // 
            // ListTitlePanel
            // 
            this.ListTitlePanel.Controls.Add(this.lbSongCount);
            this.ListTitlePanel.Controls.Add(this.pbAddSong);
            this.ListTitlePanel.Controls.Add(this.pbSearch);
            this.ListTitlePanel.Controls.Add(this.tbSearchKey);
            this.ListTitlePanel.Controls.Add(this.lbCategory);
            this.ListTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.ListTitlePanel.Name = "ListTitlePanel";
            this.ListTitlePanel.Size = new System.Drawing.Size(622, 48);
            this.ListTitlePanel.TabIndex = 0;
            // 
            // lbSongCount
            // 
            this.lbSongCount.AutoSize = true;
            this.lbSongCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSongCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbSongCount.Location = new System.Drawing.Point(135, 17);
            this.lbSongCount.Name = "lbSongCount";
            this.lbSongCount.Size = new System.Drawing.Size(51, 17);
            this.lbSongCount.TabIndex = 4;
            this.lbSongCount.Text = "0首音乐";
            // 
            // tbSearchKey
            // 
            this.tbSearchKey.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbSearchKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearchKey.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSearchKey.ForeColor = System.Drawing.Color.Gray;
            this.tbSearchKey.Location = new System.Drawing.Point(399, 11);
            this.tbSearchKey.Name = "tbSearchKey";
            this.tbSearchKey.Size = new System.Drawing.Size(163, 23);
            this.tbSearchKey.TabIndex = 1;
            this.tbSearchKey.Text = "请输入要搜索的关键字";
            this.tbSearchKey.Enter += new System.EventHandler(this.tbSearchKey_Enter);
            this.tbSearchKey.Leave += new System.EventHandler(this.tbSearchKey_Leave);
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCategory.ForeColor = System.Drawing.Color.White;
            this.lbCategory.Location = new System.Drawing.Point(31, 9);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(88, 25);
            this.lbCategory.TabIndex = 0;
            this.lbCategory.Text = "本地音乐";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cmslvList
            // 
            this.cmslvList.BackColor = System.Drawing.Color.White;
            this.cmslvList.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmslvList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPlay,
            this.tsmiFavorite,
            this.tsmiDelete,
            this.tsmiDownload});
            this.cmslvList.Name = "contextMenuStrip1";
            this.cmslvList.Size = new System.Drawing.Size(114, 124);
            // 
            // songListPanel
            // 
            this.songListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.songListPanel.BackgroundImage = global::MediaPlayer.Properties.Resources.defaultPicture;
            this.songListPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.songListPanel.Controls.Add(this.ly3);
            this.songListPanel.Controls.Add(this.ly2);
            this.songListPanel.Controls.Add(this.ly1);
            this.songListPanel.Controls.Add(this.lvSongList);
            this.songListPanel.Controls.Add(this.axWindowsMediaPlayer1);
            this.songListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songListPanel.Location = new System.Drawing.Point(0, 48);
            this.songListPanel.Name = "songListPanel";
            this.songListPanel.Size = new System.Drawing.Size(622, 459);
            this.songListPanel.TabIndex = 1;
            // 
            // ly3
            // 
            this.ly3.BackColor = System.Drawing.Color.Transparent;
            this.ly3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ly3.ForeColor = System.Drawing.Color.White;
            this.ly3.Location = new System.Drawing.Point(0, 233);
            this.ly3.Name = "ly3";
            this.ly3.Size = new System.Drawing.Size(619, 23);
            this.ly3.TabIndex = 5;
            this.ly3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ly2
            // 
            this.ly2.BackColor = System.Drawing.Color.Transparent;
            this.ly2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ly2.ForeColor = System.Drawing.Color.White;
            this.ly2.Location = new System.Drawing.Point(2, 176);
            this.ly2.Name = "ly2";
            this.ly2.Size = new System.Drawing.Size(617, 30);
            this.ly2.TabIndex = 4;
            this.ly2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ly1
            // 
            this.ly1.BackColor = System.Drawing.Color.Transparent;
            this.ly1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ly1.ForeColor = System.Drawing.Color.White;
            this.ly1.Location = new System.Drawing.Point(0, 125);
            this.ly1.Name = "ly1";
            this.ly1.Size = new System.Drawing.Size(619, 23);
            this.ly1.TabIndex = 3;
            this.ly1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvSongList
            // 
            this.lvSongList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.lvSongList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSongList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNum,
            this.colName,
            this.colSinger,
            this.colDuration,
            this.colSize});
            this.lvSongList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSongList.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvSongList.ForeColor = System.Drawing.Color.White;
            this.lvSongList.FullRowSelect = true;
            this.lvSongList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSongList.Location = new System.Drawing.Point(0, 0);
            this.lvSongList.MultiSelect = false;
            this.lvSongList.Name = "lvSongList";
            this.lvSongList.OwnerDraw = true;
            this.lvSongList.Size = new System.Drawing.Size(622, 459);
            this.lvSongList.TabIndex = 1;
            this.lvSongList.UseCompatibleStateImageBehavior = false;
            this.lvSongList.View = System.Windows.Forms.View.Details;
            this.lvSongList.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvSongList_DrawColumnHeader);
            this.lvSongList.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvSongList_DrawSubItem);
            this.lvSongList.DoubleClick += new System.EventHandler(this.lvSongList_DoubleClick);
            this.lvSongList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvSongList_RightMouseDown);
            // 
            // colNum
            // 
            this.colNum.Text = "";
            // 
            // colName
            // 
            this.colName.Text = "音乐标题";
            this.colName.Width = 197;
            // 
            // colSinger
            // 
            this.colSinger.Text = "歌手";
            this.colSinger.Width = 136;
            // 
            // colDuration
            // 
            this.colDuration.Text = "时长";
            this.colDuration.Width = 128;
            // 
            // colSize
            // 
            this.colSize.Text = "大小";
            this.colSize.Width = 101;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(517, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(204, 45);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // pbAddSong
            // 
            this.pbAddSong.Image = ((System.Drawing.Image)(resources.GetObject("pbAddSong.Image")));
            this.pbAddSong.Location = new System.Drawing.Point(219, 9);
            this.pbAddSong.Name = "pbAddSong";
            this.pbAddSong.Size = new System.Drawing.Size(99, 27);
            this.pbAddSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddSong.TabIndex = 3;
            this.pbAddSong.TabStop = false;
            this.pbAddSong.Click += new System.EventHandler(this.tsmiOpenFile_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(580, 10);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(24, 24);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 2;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // tsmiDeleteSongList
            // 
            this.tsmiDeleteSongList.BackColor = System.Drawing.Color.Teal;
            this.tsmiDeleteSongList.ForeColor = System.Drawing.Color.White;
            this.tsmiDeleteSongList.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDeleteSongList.Image")));
            this.tsmiDeleteSongList.Name = "tsmiDeleteSongList";
            this.tsmiDeleteSongList.Size = new System.Drawing.Size(142, 30);
            this.tsmiDeleteSongList.Text = "删除歌单";
            this.tsmiDeleteSongList.Click += new System.EventHandler(this.tsmiDeleteSongList_Click);
            // 
            // tsmiAddSongs
            // 
            this.tsmiAddSongs.BackColor = System.Drawing.Color.Teal;
            this.tsmiAddSongs.ForeColor = System.Drawing.Color.White;
            this.tsmiAddSongs.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddSongs.Image")));
            this.tsmiAddSongs.Name = "tsmiAddSongs";
            this.tsmiAddSongs.Size = new System.Drawing.Size(142, 30);
            this.tsmiAddSongs.Text = "添加歌曲";
            this.tsmiAddSongs.Click += new System.EventHandler(this.tsmiAddSongs_Click);
            // 
            // pbAddList
            // 
            this.pbAddList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbAddList.Image = ((System.Drawing.Image)(resources.GetObject("pbAddList.Image")));
            this.pbAddList.Location = new System.Drawing.Point(216, 6);
            this.pbAddList.Name = "pbAddList";
            this.pbAddList.Size = new System.Drawing.Size(26, 26);
            this.pbAddList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddList.TabIndex = 1;
            this.pbAddList.TabStop = false;
            this.pbAddList.Click += new System.EventHandler(this.pbAddList_Click);
            // 
            // pbVolume
            // 
            this.pbVolume.Image = ((System.Drawing.Image)(resources.GetObject("pbVolume.Image")));
            this.pbVolume.Location = new System.Drawing.Point(735, 25);
            this.pbVolume.Name = "pbVolume";
            this.pbVolume.Size = new System.Drawing.Size(28, 28);
            this.pbVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVolume.TabIndex = 8;
            this.pbVolume.TabStop = false;
            // 
            // btnPlayMode
            // 
            this.btnPlayMode.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayMode.Image")));
            this.btnPlayMode.Location = new System.Drawing.Point(695, 25);
            this.btnPlayMode.Name = "btnPlayMode";
            this.btnPlayMode.Size = new System.Drawing.Size(28, 28);
            this.btnPlayMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlayMode.TabIndex = 6;
            this.btnPlayMode.TabStop = false;
            this.btnPlayMode.Click += new System.EventHandler(this.btnPlayMode_Click);
            // 
            // pbAlbumImage
            // 
            this.pbAlbumImage.Image = global::MediaPlayer.Properties.Resources.defaultPicture;
            this.pbAlbumImage.Location = new System.Drawing.Point(189, 13);
            this.pbAlbumImage.Name = "pbAlbumImage";
            this.pbAlbumImage.Size = new System.Drawing.Size(57, 47);
            this.pbAlbumImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlbumImage.TabIndex = 0;
            this.pbAlbumImage.TabStop = false;
            this.pbAlbumImage.Click += new System.EventHandler(this.pbAlbumImage_Click);
            this.pbAlbumImage.MouseEnter += new System.EventHandler(this.MoveEnter_ChangeIconToHooverStyle);
            this.pbAlbumImage.MouseLeave += new System.EventHandler(this.MoveLeave_ChangeIconToHooverStyle);
            // 
            // pbPlay
            // 
            this.pbPlay.Image = ((System.Drawing.Image)(resources.GetObject("pbPlay.Image")));
            this.pbPlay.Location = new System.Drawing.Point(71, 13);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(47, 47);
            this.pbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlay.TabIndex = 2;
            this.pbPlay.TabStop = false;
            this.pbPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pbNext
            // 
            this.pbNext.Image = ((System.Drawing.Image)(resources.GetObject("pbNext.Image")));
            this.pbNext.Location = new System.Drawing.Point(124, 13);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(47, 47);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNext.TabIndex = 1;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(18, 13);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(47, 47);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 0;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbMin
            // 
            this.pbMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbMin.Image = global::MediaPlayer.Properties.Resources._11;
            this.pbMin.Location = new System.Drawing.Point(781, 0);
            this.pbMin.Name = "pbMin";
            this.pbMin.Size = new System.Drawing.Size(31, 31);
            this.pbMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMin.TabIndex = 3;
            this.pbMin.TabStop = false;
            this.pbMin.Click += new System.EventHandler(this.FormControlButton_Click);
            // 
            // pbMax
            // 
            this.pbMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbMax.Image = global::MediaPlayer.Properties.Resources._22;
            this.pbMax.Location = new System.Drawing.Point(812, 0);
            this.pbMax.Name = "pbMax";
            this.pbMax.Size = new System.Drawing.Size(31, 31);
            this.pbMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMax.TabIndex = 2;
            this.pbMax.TabStop = false;
            this.pbMax.Click += new System.EventHandler(this.FormControlButton_Click);
            // 
            // pbClose
            // 
            this.pbClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbClose.Image = global::MediaPlayer.Properties.Resources._33;
            this.pbClose.Location = new System.Drawing.Point(843, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(31, 31);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.FormControlButton_Click);
            // 
            // tsmiPlay
            // 
            this.tsmiPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tsmiPlay.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmiPlay.ForeColor = System.Drawing.Color.White;
            this.tsmiPlay.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPlay.Image")));
            this.tsmiPlay.Name = "tsmiPlay";
            this.tsmiPlay.Size = new System.Drawing.Size(113, 30);
            this.tsmiPlay.Text = "播放";
            this.tsmiPlay.Click += new System.EventHandler(this.tsmiPlay_Click);
            // 
            // tsmiFavorite
            // 
            this.tsmiFavorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tsmiFavorite.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmiFavorite.ForeColor = System.Drawing.Color.White;
            this.tsmiFavorite.Image = ((System.Drawing.Image)(resources.GetObject("tsmiFavorite.Image")));
            this.tsmiFavorite.Name = "tsmiFavorite";
            this.tsmiFavorite.Size = new System.Drawing.Size(113, 30);
            this.tsmiFavorite.Text = "收藏";
            this.tsmiFavorite.Click += new System.EventHandler(this.tsmiFavorite_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tsmiDelete.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmiDelete.ForeColor = System.Drawing.Color.White;
            this.tsmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDelete.Image")));
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(113, 30);
            this.tsmiDelete.Text = "删除";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiDownload
            // 
            this.tsmiDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tsmiDownload.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmiDownload.ForeColor = System.Drawing.Color.White;
            this.tsmiDownload.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDownload.Image")));
            this.tsmiDownload.Name = "tsmiDownload";
            this.tsmiDownload.Size = new System.Drawing.Size(113, 30);
            this.tsmiDownload.Text = "下载";
            this.tsmiDownload.Click += new System.EventHandler(this.tsmiDownload_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(874, 613);
            this.Controls.Add(this.WindowPanel);
            this.Controls.Add(this.ListPanel);
            this.Controls.Add(this.ControlBarPanel);
            this.Controls.Add(this.TitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TitlePanel.ResumeLayout(false);
            this.ControlBarPanel.ResumeLayout(false);
            this.ControlBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbMove)).EndInit();
            this.ListPanel.ResumeLayout(false);
            this.cmsSongList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.WindowPanel.ResumeLayout(false);
            this.ListTitlePanel.ResumeLayout(false);
            this.ListTitlePanel.PerformLayout();
            this.cmslvList.ResumeLayout(false);
            this.songListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.PictureBox pbMin;
        private System.Windows.Forms.PictureBox pbMax;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel ControlBarPanel;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.PictureBox pbAlbumImage;
        private System.Windows.Forms.Panel WindowPanel;
        private System.Windows.Forms.Label lbSongName;
        private System.Windows.Forms.TrackBar tkbMove;
        private System.Windows.Forms.PictureBox pbPlay;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.PictureBox pbVolume;
        private System.Windows.Forms.PictureBox btnPlayMode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox lbMenu;
        private System.Windows.Forms.Panel songListPanel;
        private System.Windows.Forms.Panel ListTitlePanel;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox tbSearchKey;
        private System.Windows.Forms.Label lbCategory;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pbAddList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbAddSong;
        private System.Windows.Forms.Label lbSongCount;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListView lvSongList;
        private System.Windows.Forms.ColumnHeader colNum;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSinger;
        private System.Windows.Forms.ColumnHeader colDuration;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.Label lbTimeShow;
        private System.Windows.Forms.ContextMenuStrip cmslvList;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlay;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiFavorite;
        private System.Windows.Forms.TrackBar tkbVol;
        private System.Windows.Forms.ToolStripMenuItem tsmiDownload;
        private System.Windows.Forms.ContextMenuStrip cmsSongList;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteSongList;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddSongs;
        private System.Windows.Forms.Label ly3;
        private System.Windows.Forms.Label ly2;
        private System.Windows.Forms.Label ly1;
    }
}