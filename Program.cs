using System;
using unit03_jumper.GameCalculations;
//The main program for the game. Calls the director class, and the gamestart method.

namespace unit03_jumper
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Director.GameStart();
        }
    }
}
