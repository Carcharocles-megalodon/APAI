using System;
using System.IO;
using System.Text;

namespace InvertedAPAIEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllText("lines.txt").Split('.', StringSplitOptions.RemoveEmptyEntries);
            string[] inverted = new string[lines.Length];
            int j = 0;
            while (j < lines.Length-1)
            {
                for (int i = lines.Length; i > 0; i--)
                {
                    inverted[j] = lines[i];
                    j++;
                }
            }
            Console.WriteLine(inverted);
            File.WriteAllLines("lines.txt", inverted);
        }
    }
}
