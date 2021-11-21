using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    public class SandL
    {
        public const int startpos = 0;
        public const int wins = 100;
        public void SL()
        {
            //READ A NUMBER 0-6 USING RANDOM --

            Console.WriteLine("UC2");
            Console.WriteLine("-------------------------");
            Random r1 = new Random();
            //    Random r2 = new Random();
            int dice = r1.Next(1, 7);
            //     int swi = r2.Next(1, 4);
            Console.WriteLine("Rolled dice value is:-   "+dice);
            Console.WriteLine("-------------------------");
        }
    }
}
