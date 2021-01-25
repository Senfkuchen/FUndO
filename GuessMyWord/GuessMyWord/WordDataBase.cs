
namespace GuessMyWord
{
    internal class WordDataBase : IWordDataBase
    {
        private readonly string[] words = new[]
        {
            //todo: sort in categories
            "Auto", "Banane", "Salz", "Schinken", "Rahmsoße", "Fußball", "Bass",
            "Wald", "Spaziergang", "Löffel", "blau", "grün", "niemals", "Papier",
            "Mama", "Hund", "programmieren", "Haus", "Garten", "Pfannkuchen",
            "Nudeln"
        };

        string[] IWordDataBase.words { get => words; }

        public string[] getWordArray()
        {
            return words;
        }
    }
}
