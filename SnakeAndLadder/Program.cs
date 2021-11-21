using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO SNAKE AND LADDER PROGRAM");

            //Calling snake and ladder method
            SandL sand = new SandL();
            sand.SL();
        }
    }
}
