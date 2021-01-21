using System;

namespace GuessMyWord
{
    class CustomConsole
    {
        public CustomConsole()
        {
        }

        public char input()
        {
            char key = Console.ReadKey().KeyChar;
            return key;
            //this.referenceToModel.updateWithGuessKey(key);
            //Console.Clear();
        }

        public void draw(Model model)
        {
            Console.Clear();

            if (model.programState.Equals(ProgramState.Starting))
            {
                Console.WriteLine("Startbildschirm.");
            }

            else if (model.programState.Equals(ProgramState.InProgress))
            {
                Console.WriteLine($"Wort : {model.SolvedWord}\n");
            }
            else if (model.programState.Equals(ProgramState.Solved))
            {
                Console.WriteLine($"Lösungswort: : {model.GuessWord}\n");
                Console.WriteLine($"Fehlversuche : {model.CountFails}");
                Console.WriteLine("Nochmal : j für ja!");
            }
            else if (model.programState.Equals(ProgramState.Finishing))
            {
                Console.WriteLine($"Das Programm wird beendet.\n");
            }
            else if (model.programState.Equals(ProgramState.Interrupted))
            {
                Console.WriteLine($"Programm wurde abgebrochen! Fehlversuche bis dahin: {model.CountFails}");                
            }
        }
    }
}
