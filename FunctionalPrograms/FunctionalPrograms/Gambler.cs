using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Gambler
    {
        public static void Gambling()
        {

            int win = 0;
            int stack = Util.userinputs();
           double trails = Util.UserInput();
            Util.CheckGambling(win, trails);

            double Percentage = win / trails * 100;
            Console.WriteLine("Percentage of wins" + Percentage);
            Console.WriteLine("Wins " + win);


        }

    }
}
