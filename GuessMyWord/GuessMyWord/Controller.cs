
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
                console.draw(model);
                var inputKey1 = console.input();
                model.updateModel(inputKey1);
                do
                {
                    console.draw(model);//state InProgress
                    var inputKey2 = console.input();
                    model.updateWithGuessKey(inputKey2);

                } while (!model.programState.Equals(ProgramState.Solved) 
                && !model.programState.Equals(ProgramState.Interrupted) );

                console.draw(model);
                var inputKey3 = console.input();
                model.updateModel(inputKey3);

            } while (model.programState.Equals(ProgramState.Starting));

            console.draw(model);
            console.input();
        }
    }
}
