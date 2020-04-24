using System;

namespace AnagramTarefa
{
    class Program
    {
        static void Main(string[] args)
        {
            Anagram a;

            string command = Console.ReadLine();
            while(command != "End")
            {
                string[] separate = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                a = new Anagram(separate[0], separate[1]);
                Console.WriteLine(a.IsItAnagram());
                command = Console.ReadLine();
            }
        }
    }
}
