﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyWord
{
    class Program
    {
        public Program()
        {

        }
        static void Main(string[] args)
        {
            Controller controller = new Controller();

            controller.run();
        }
    }
}
