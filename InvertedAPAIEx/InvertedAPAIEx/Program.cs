using System;
using System.IO;
using System.Text;

namespace InvertedAPAIEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("lines.txt");
            string[] inverted = new string[lines.Length];
            int j = 0;
            while (j < lines.Length-1)
            {
                for (int i = lines.Length-1; i > 0; i--)
                {
                    inverted[j] = lines[i];
                    j++;
                }
            }
            string path = @"C:\Users\Geral\source\repos\APAI\InvertedAPAIEx\lines_inverted.txt";
            File.Create(path);
            
            File.WriteAllLines(path, inverted);
        }
    }
}
