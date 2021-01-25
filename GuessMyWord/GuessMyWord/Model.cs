using System.Linq;

namespace GuessMyWord
{
    class Model
    {
        public string GuessWord { get; set; }
        public string SolvedWord { get; set; }
        public int CountFails { get; set; }
        public ProgramState programState { get; set; }

        private WordGenerator wordGenerator = new WordGenerator();

        public Model()
        {
            InitializeModel();            
        }

        public void InitializeModel()
        {
            GuessWord = wordGenerator.SelectRandomWord();
            SolvedWord = new string('*', GuessWord.Length);
            CountFails = 0;
            programState = ProgramState.Starting;
        }

        public void updateModel(char inputKey)
        {
            if (programState.Equals(ProgramState.Starting))
            {
                //React to input
                programState = ProgramState.InProgress;
            }
            else if (programState.Equals(ProgramState.InProgress))
            {
                this.updateWithGuessKey(inputKey);
            }
            else if (programState.Equals(ProgramState.Solved))
            {
                /*Console.WriteLine("Nochmal : j für ja!");*///-> Das muss nach draw für State solved
                if (inputKey.Equals('j'))
                {
                    programState = ProgramState.Starting;
                    this.InitializeModel();
                }
                else
                {
                    programState = ProgramState.Finishing;
                }
            }
        }

        public void updateWithGuessKey(char key)
        {
            if (key.Equals('@'))
            {
                programState = ProgramState.Interrupted;
                return;
            }

            if (!GuessWord.Contains(key))
            {
                CountFails++;
            }
            
            foreach (var letterTuple in GuessWord.Select((x, i) => new { Value = x, Index = i }))
            {
                if (letterTuple.Value.Equals(key))
                {
                    SolvedWord = SolvedWord.Remove(letterTuple.Index, 1).Insert(letterTuple.Index, key.ToString());
                }
            }
            if (SolvedWord.Equals(GuessWord))
            {
                programState = ProgramState.Solved;
            }
        }
    }
}
