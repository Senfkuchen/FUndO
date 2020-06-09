using System;

namespace GuessMyWord
{   
    class WordGenerator
    {
        string[] words = new[] { "Rad", "Ball", "Käse" };
        Random rand = new Random();

        public string selectWord()
        {
            int randomIndex = rand.Next(0, words.Length);
            return words[randomIndex];
        }
    }
}
