using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyWord
{    
    class Controller
    {
        Model model;
        CustomConsole console;

        public Controller()
        {
            model = new Model();
            console = new CustomConsole();
        }

        public void run()
        {
            do
            {
                console.draw(model);//state InProgress
                var inputKey = console.input();
                model.updateWithGuessKey(inputKey);

            } while (model.programState == ProgramState.InProgress);
            console.draw(model);
        }

    }
}
