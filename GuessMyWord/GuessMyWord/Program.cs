using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyWord
{
    class Program
    {
        private static readonly ModelAndLogic model = new ModelAndLogic();
        static void Main(string[] args)
        {
            char key;
            do
            { 
                Console.WriteLine($"Wort : {model.SolvedWord}\n");
                key = Console.ReadKey().KeyChar;
                model.updateWithGuessKey(key);
                Console.Clear();
            } while (!key.Equals('@') && !model.SolvedWord.Equals(model.GuessWord));
            Console.WriteLine($"Lösungswort: : {model.GuessWord}\n");
            Console.WriteLine($"Fehlversuche : {model.CountFails}");
            Console.ReadKey();

            //Idee Console und logik mit Event verbinden->OnChange ->Redraw oder so ähnlich


        }
    }
}
