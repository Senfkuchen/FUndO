using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyWord
{
    class GuessMyWordProgramm
    {
        private readonly ModelAndLogic model;
        private readonly CustomConsole customConsole;

        public GuessMyWordProgramm()
        {
            model = new ModelAndLogic();
            customConsole = new CustomConsole(model);
        }

        public void run()
        { 
            do
            {
                customConsole.draw();//state InProgress
                customConsole.input();

            } while (model.programState == ProgramState.InProgress);
            customConsole.draw();


            //console(draw, input)
            //logic(do while)
            //model(data, call draw, call input)
            //char key;
            //do
            //{
            //    Console.WriteLine($"Wort : {model.SolvedWord}\n");
            //    key = Console.ReadKey().KeyChar;
            //    model.updateWithGuessKey(key);
            //    Console.Clear();
            //} while (!key.Equals('@') && !model.SolvedWord.Equals(model.GuessWord));
            //Console.WriteLine($"Lösungswort: : {model.GuessWord}\n");
            //Console.WriteLine($"Fehlversuche : {model.CountFails}");
            //Console.ReadKey();

            ////Idee Console und logik mit Event verbinden->OnChange ->Redraw oder so ähnlich
        }

    }
}
