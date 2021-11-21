using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    public class SandL
    {
        int move = 0;
        int restart = 0;
        public const int lad = 1;
        public const int snake = 2;
        public void SL()
        {
            Console.WriteLine("UC4");
            Console.WriteLine("-------------------------");
            for (move = 0; move < 100; move++)
            {
                Random r = new Random();
                int dice = r.Next(1, 6);
                Random sel = new Random();
                int choice = sel.Next(0, 3);
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("No play");
                        break;
                    case 1:
                        Console.WriteLine("Got ladder");
                        move = move + dice;
                        Console.WriteLine("Coin position at " + move);
                        break;
                    case 2:
                        Console.WriteLine("Reached snake");
                        move = move - dice;
                        if (move < 0)
                        {
                            Console.WriteLine("Restarting -- Coin position at " + restart);
                            move = restart;
                        }
                        else
                        {
                            Console.WriteLine("Coin position at " + move);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;


                }

            }
            Console.WriteLine("-------------------------");
        }
    }
}
