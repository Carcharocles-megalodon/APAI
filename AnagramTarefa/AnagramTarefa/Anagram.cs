using System;
using System.Collections.Generic;
using System.Text;

namespace AnagramTarefa
{
    class Anagram
    {
        public string word1;
        public string word2;


        public Anagram(string word1, string word2)
        {
            this.word1 = word1;
            this.word2 = word2;
        }
        public bool IsItAnagram()
        {
            var word1Char = word1.ToLower().ToCharArray();
            var word2Char = word2.ToLower().ToCharArray();

            Array.Sort(word1Char);
            Array.Sort(word2Char);


            if (word1.Length != word2.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < word2Char.Length; i++)
                {
                    if (word1Char[i] != word2Char[i])
                    {
                        return false;
                    }

                }
                return true;
            }
        }
    }
}
