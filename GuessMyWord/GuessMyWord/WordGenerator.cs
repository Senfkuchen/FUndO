using System;
using System.Collections.Generic;

namespace GuessMyWord
{   
    public class WordGenerator
    {
        private readonly string[] words;
        IWordDataBase wordDataBase;

        List<int> usedWordIndexes;

        public WordGenerator()
        {
            usedWordIndexes = new List<int>();
            wordDataBase = new WordDataBase();
            words = wordDataBase.getWordArray();
        }

        //Special constructor for Unit Testing
        public WordGenerator(IWordDataBase wordDataBase)
        {
            usedWordIndexes = new List<int>();
            this.wordDataBase = wordDataBase;
            words = wordDataBase.getWordArray();
        }

        /// <summary>
        /// Select a random word from the array of words without checking if the word was already selected/used.
        /// </summary>
        /// <returns>The selected word</returns>
        public string SelectRandomWord()
        {
            var rand = new Random();
            var randomIndex = rand.Next(0, this.words.Length);
            return this.words[randomIndex];
        }

        /// <summary>
        /// Select a random word from the array of words. Check that the selected word was not selected/used before.
        /// </summary>
        /// <returns>The selected word</returns>
        public string SelectUnusedWord()
        {
            if (usedWordIndexes.Count.Equals(words.Length))
            {
                throw new Exception("All words were used before, no unusedWord can be selected.");
            }
            var rand = new Random();
            var randomIndex = -1;
            while (randomIndex == -1 || usedWordIndexes.Contains(randomIndex))
            {
                randomIndex = rand.Next(0, this.words.Length);
            }
            usedWordIndexes.Add(randomIndex);
            return this.words[randomIndex];
        }

        /// <summary>
        /// Reset the list of used words.
        /// </summary>
        public void resetUsedWordList()
        {
            usedWordIndexes.Clear();
        }
    }
}
