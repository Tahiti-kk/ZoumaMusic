using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    [Serializable]
    public class SongList
    {
        private string songListName;

        public List<SongsInfo> Songs { get; set; } 
        public string SongListName { get => songListName; set => songListName = value; }

        public SongList()
        {

        }

        public SongList(List<SongsInfo> songs, string songListName)
        {
            Songs = songs;
            SongListName = songListName;
        }
    }
}
