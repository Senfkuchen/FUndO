using System;

namespace GuessMyWord
{   
    class WordGenerator
    {
        private readonly string[] words = new[]
        {
            //todo: sort in categories
            "Auto", "Banane", "Salz", "Schinken", "Rahmsoße", "Fußball", "Bass",
            "Wald", "Spaziergang", "Löffel", "blau", "grün", "niemals", "Papier",
            "Mama", "Hund", "programmieren", "Haus", "Garten", "Pfannkuchen",
            "Nudeln"
        };

        public WordGenerator()
        {

        }

        public string SelectWord()
        {
            var rand = new Random();
            var randomIndex = rand.Next(0, this.words.Length);
            return this.words[randomIndex];
        }
    }
}
