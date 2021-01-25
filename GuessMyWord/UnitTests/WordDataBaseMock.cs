using GuessMyWord;

namespace UnitTests
{
    class WordDataBaseMock : IWordDataBase
    {
        public readonly string[] words = new[]
        {
            "Eins", "Zwei", "Drei", "View", "Fuenf"
        };

        string[] IWordDataBase.words => words;
        
        public string[] getWordArray()
        {
            return words;
        }
    }
}
