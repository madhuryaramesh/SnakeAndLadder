using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    public class SandL
    {
        int move = 0;
        int restart = 0;
        int newPos = 0;
        public const int lad = 1;
        public const int snake = 2;
        public const int wins = 100;
        public void SL()
        {
            Console.WriteLine("UC5");
            Console.WriteLine("-------------------------");
            while (newPos != 100)
            {
                for (move = 0; move <=wins; move++)
                {
                Random r = new Random();
                int dice = r.Next(1, 7);
                Random sel = new Random();
                int choice = sel.Next(1, 3);
                //while (newPos == wins)
                //{
                switch (choice)
                {
                    //case 0:
                    //    Console.WriteLine("No play");
                    //    break;
                    case 1:
                        //while (newPos == wins)
                        // {
                        Console.WriteLine("Got ladder");
                        move = move + dice;
                        newPos = move;
                        move++;
                        //Console.WriteLine("Coin position at " + move);
                        if (newPos == 100)
                        {
                            Console.WriteLine("PLAYER WON AND REACHED POSITION " + newPos);
                        }
                        else if (newPos > 100)
                        {
                            Console.WriteLine("NO MOVES");
                        }
                        else
                        {
                            Console.WriteLine("Coin position at " + newPos);
                            newPos++;
                        }
                        // }
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
            }
            Console.WriteLine("-------------------------");
        }
    }
}
