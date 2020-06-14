using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyWord
{
    class ModelAndLogic
    {
        public string GuessWord { get; set; }
        public string SolvedWord { get; set; }
        public int CountFails { get; set; }

        private WordGenerator wordGenerator = new WordGenerator();

        public ModelAndLogic()
        {
            InitializeModel();
        }

        public void InitializeModel()
        {
            GuessWord = wordGenerator.SelectWord();
            SolvedWord = new string('*', GuessWord.Length);
            CountFails = 0;
        }

        public void updateWithGuessKey(char key)
        {
            if (!GuessWord.Contains(key))
            {
                CountFails++;
            }
            //Aufbereitung des bisher gelösten Wortes -> solvedWord
            //Console.Clear();.>Wohin?
            foreach (var letterTuple in GuessWord.Select((x, i) => new { Value = x, Index = i }))
            {
                if (letterTuple.Value.Equals(key))
                {
                    SolvedWord = SolvedWord.Remove(letterTuple.Index, 1).Insert(letterTuple.Index, key.ToString());
                }
            }
        }

    }
}
