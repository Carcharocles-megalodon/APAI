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

            return word1Char == word2Char;
        }
    }
}
