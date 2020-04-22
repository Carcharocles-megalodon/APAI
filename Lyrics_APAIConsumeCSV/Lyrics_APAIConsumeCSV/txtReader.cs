using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lyrics_APAIConsumeCSV
{
    public class txtReader
    {
        public int[] group;
        public string[] repeat;


        public txtReader(string path)
        {

            string lyric = File.ReadAllText(path);
            string[] lyrics = lyric.Split(' ', ',', StringSplitOptions.RemoveEmptyEntries);
            HashSet<string> group_ = new HashSet<string>();

            for (int i = 0; i < lyrics.Length; i++)
            {
                lyrics[i].ToLower();
            }
            for (int i = 0; i < lyrics.Length; i++)
            {
                group_.Add(lyrics[i]);
            }
            group = new int[group_.Count];
            repeat = new string[group.Length];
            for (int i = 0; i < group.Length-1; i++)
            {
                for (int j = 1; i < group.Length-1; j++)
                {
                    if (lyrics[i] == lyrics[j])
                    {
                        group[i]++;
                        repeat[i] = lyrics[i];
                    }
                }
            }


            /*public override string ToString()
            {
                return Console.WriteLine("Repetitions are as such:\n\t{0} is repeated {1} times", repeat[i], group[i]);
            }*/
        }
    }
}
