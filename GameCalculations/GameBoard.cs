using System;

namespace unit03_jumper.GameCalculations;

class GameBoard
{
//The game board in all it's stages. The player gets four guesses before they lose and need to restart.

    public GameBoard()
    {

    }
    public static void printBoard(int wrong)
    {
        //The actual iterations of the game board, cycled by the amount of wrong guesses.
        if (wrong == 0)
        {
            Console.WriteLine("\n  ___ ");
            Console.WriteLine(" /   \\");
            Console.WriteLine(" \\   /");
            Console.WriteLine("  \\ /");
            Console.WriteLine("   o");
            Console.WriteLine("  /|\\");
            Console.WriteLine("  / \\");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("^^^^^^^^");
        }
        else if (wrong == 1)
        {
            Console.WriteLine("\n  /   \\");
            Console.WriteLine("  \\   /");
            Console.WriteLine("   \\ /");
            Console.WriteLine("    o");
            Console.WriteLine("   /|\\");
            Console.WriteLine("   / \\");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("^^^^^^^^");
        }
        else if (wrong == 2)
        {
            Console.WriteLine("\n  \\   /");
            Console.WriteLine("   \\ /");
            Console.WriteLine("    o");
            Console.WriteLine("   /|\\");
            Console.WriteLine("   / \\");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("^^^^^^^^");
        }
        else if (wrong == 3)
        {
            Console.WriteLine("\n  \\ /");
            Console.WriteLine("   o");
            Console.WriteLine("  /|\\");
            Console.WriteLine("  / \\");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("^^^^^^^^");
        }
        else if (wrong == 4)
        {
            Console.WriteLine("\n    x");
            Console.WriteLine("   /|\\");
            Console.WriteLine("   / \\");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("^^^^^^^^");
        }
    }
}