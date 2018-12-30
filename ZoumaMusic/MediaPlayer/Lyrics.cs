using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MediaPlayer
{
    class Lyrics
    {


        public static int cnt;   //歌词行数
        public static double[] times = new double[200];
        public static string[] lyrics = new string[200];

        public static void ReadLrc(string fileName)
        {
            cnt = 0;
            for (int i = 0; i < times.Length; i++) times[i] = -1;

            string lyric, one_line;
            StreamReader infile = new StreamReader(fileName, System.Text.Encoding.UTF8);
            lyric = infile.ReadLine();

            string pattern = @"\[(?<time>(.*?))\](?<line>(.*?))\\n";
            Regex rx = new Regex(pattern);
            MatchCollection mc = rx.Matches(lyric);
            foreach (Match item in mc)
            {
                if (item.Result("${line}") == "")
                {
                    continue;
                }
                one_line = "[" + item.Result("${time}") + "]" + item.Result("${line}");
                ParseOneLine(one_line);
            }
            infile.Close();
        }

        static void ParseOneLine(string one_line)
        {
            Regex regex = new Regex(@"\[\d{2}:\d{2}\.\d{2,3}\]");
            MatchCollection matchs = regex.Matches(one_line);
            if (matchs.Count > 0)
            {
                Match lastmatch = matchs[matchs.Count - 1];

                string ly = one_line.Substring(lastmatch.Index + lastmatch.Length);

                foreach (Match match in matchs)
                {
                    string timestr = match.Value.Substring(1, 8);
                    double tm = Convert.ToDouble(timestr.Substring(0, 2)) * 60 + Convert.ToDouble(timestr.Substring(3));
                    InsertOneItem(tm, ly);
                }
            }
        }

        static void InsertOneItem(double tm, string ly)
        {
            int pos = -1;
            for (int i = 0; i < times.Length; i++)
            {
                if (tm < times[i] || times[i] == -1)
                {
                    pos = i;
                    break;
                }
            }

            for (int i = times.Length - 1; i < pos; i--)
            {
                times[i + 1] = times[i];
                lyrics[i + 1] = lyrics[i];
            }

            times[pos] = tm;
            lyrics[pos] = ly;
            cnt = cnt + 1;
        }
    }
}
