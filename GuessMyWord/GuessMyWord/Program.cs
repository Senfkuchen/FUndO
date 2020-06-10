using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyWord
{
    class Program
    {
        private static readonly WordGenerator WordGenerator = new WordGenerator();
        static void Main(string[] args)
        {
            var guessWord = WordGenerator.SelectWord();
            var solvedWord = new string('*', guessWord.Length);
            char key;
            int count = 0;
            do
            { 
                Console.WriteLine($"Wort : {solvedWord}\n");
                count++;
                key = Console.ReadKey().KeyChar;
                Console.Clear();
                foreach (var letterTuple in guessWord.Select((x, i) => new { Value = x, Index = i }))
                {
                    if (letterTuple.Value.Equals(key))
                    {
                        solvedWord = solvedWord.Remove(letterTuple.Index, 1).Insert(letterTuple.Index, key.ToString());
                    }
                }


            } while (!key.Equals('@') && !solvedWord.Equals(guessWord));
            Console.WriteLine($"Lösungswort: : {guessWord}\n");
            Console.WriteLine($"Versuche : {count}");
            Console.ReadKey();
        }
    }
}
