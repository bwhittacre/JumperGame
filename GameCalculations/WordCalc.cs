using System;
using System.Collections.Generic;
namespace unit03_jumper.GameCalculations;

public class WordMath
{
//The actual calculation behind the amonut of words needed to guess the word.

    public WordMath()
    {

    }
    public static int printWord(List<char> lettersGuessed, String newWord)
    {
        //This method compares the letters the player has guessed to the word itself to see how
        //close they are to getting it right or wrong.
        int counter = 0;
        int correctLetter = 0;
        Console.Write("\n");
        foreach (char c in newWord)
        {
            if (lettersGuessed.Contains(c))
            {
                Console.Write(c + " ");
                correctLetter++;
            }
            else
            {
                Console.Write("  ");
            }
            counter++;
        }
        return correctLetter;
    }

    public static void lineMagic(String newWord)
    {
        //Creates the lines underneath the word to show how many guesses are needed.
        Console.Write("\r");
        foreach (char c in newWord)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("\u0305 ");
        }
    }
}
