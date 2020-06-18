using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyWord
{
    class CustomConsole
    {
        ModelAndLogic referenceToModel;
        public CustomConsole(ModelAndLogic model)
        {
            referenceToModel = model;
        }

        public void input()
        {
            char key = Console.ReadKey().KeyChar;
            this.referenceToModel.updateWithGuessKey(key);
            Console.Clear();
        }

        public void draw()
        {
            if (referenceToModel.programState.Equals(ProgramState.InProgress))
            {
                Console.WriteLine($"Wort : {referenceToModel.SolvedWord}\n");
            }
            else if (referenceToModel.programState.Equals(ProgramState.Finishing))
            {
                Console.WriteLine($"Lösungswort: : {referenceToModel.GuessWord}\n");
                Console.WriteLine($"Fehlversuche : {referenceToModel.CountFails}");
                Console.ReadKey();
            }
            else if (referenceToModel.programState.Equals(ProgramState.Interrupted))
            {
                Console.WriteLine($"Programm wurde abgebrochen! Fehlversuche bis dahin: {referenceToModel.CountFails}");
                Console.ReadKey();
            }
        }
    }
}
