using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyWord
{
    class Program
    {
        static WordGenerator wordGenerator = new WordGenerator();
        static void Main(string[] args)
        {
            var guessWord = wordGenerator.selectWord();

        }
    }
}
