using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;

namespace MediaPlayer
{
    public class SongListService
    {
        public List<SongList> songLists = new List<SongList>();

        public SongListService()
        {
        }

        public SongListService(List<SongList> songLists)
        {
            this.songLists = songLists;
        }

        public void AddList(string listName)
        {
            SongList songList = new SongList();
            songList.Songs = new List<SongsInfo>();
            songList.SongListName = listName;
            songLists.Add(songList);
        }

        public void DelList(SongList songList)
        {
            songLists.Remove(songList);
        }

        public void Export(string path)
        {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SongListService));
                string xmlFileName = path;
                FileStream fs = new FileStream(xmlFileName, FileMode.Create);
                xmlSerializer.Serialize(fs, this);
                fs.Close();
        }

        public static SongListService Import(string path)
        {   
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SongListService));
            SongListService songListService = (SongListService)xmlSerializer.Deserialize(file);
            file.Close();
            return songListService;
        }

    }
}
