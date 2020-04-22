using System;

namespace Lyrics_APAIConsumeCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            txtReader reader = new txtReader("lyrics.txt");
            Console.WriteLine("Repetitions are as such:");
            for (int i = 0; i<reader.group.Length; i++)
            {
                
                Console.WriteLine("{0} is repeated {1} times\n", reader.repeat[i], reader.group[i]);
            }
        }
    }
}
