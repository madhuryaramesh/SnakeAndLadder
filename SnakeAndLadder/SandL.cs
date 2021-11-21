using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    public class SandL
    {
        public const int noPlay = 1;
        public const int lad = 2;
        public const int snake = 3;
        public const int wins = 100;
        public void SL()
        {
            Console.WriteLine("UC3");
            Console.WriteLine("-------------------------");
            Random r1 = new Random();
            Random r2 = new Random();
            int dice = r1.Next(1, 7);
            int swi = r2.Next(1, 4);
            int move = 0;
            //while(move<wins)
            //{
            switch (swi)
            {
                case noPlay:
                    //to print no play
                    Console.WriteLine("The position moved is :- " + move);
                    Console.WriteLine("Hence No Play");
                    break;
                case lad:
                    //to print ladder position
                    move = move + dice;
                    Console.WriteLine("The position is moved forward by   " + move);
                    break;
                case snake:
                    // to print snake position
                    move = move - dice;
                    Console.WriteLine("The position is moved backward by  " + dice);
                    break;

                default:
                    Console.WriteLine("INVALID NUMBER");
                    break;
            }

            //}

            Console.WriteLine("-------------------------");
        }
    }
}
