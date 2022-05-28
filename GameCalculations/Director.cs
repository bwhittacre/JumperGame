using System;
using System.Collections.Generic;
namespace unit03_jumper.GameCalculations;

class Director
{
    //The class that combines all others into a cohesive program. Runs the main game loop, by generating the board,
    //the guesses, and whether the guess was correct or not.
    public static Dictionary dictionary = new Dictionary();
    public static GameBoard board = new GameBoard();
    public static WordMath word = new WordMath();
    public static void GameStart()
    {
        foreach (char c in Dictionary.newWord)
        {
            Console.Write("_ ");
        }
        
        int wordLength = Dictionary.newWord.Length;
        int wrong = 0;
        List<char> numLettersGuessed = new List<char>();
        int lettersRight = 0;
        GameBoard.printBoard(wrong);
        while(wrong != 4 && lettersRight != wordLength)
        {
            Console.Write("\nGuess a letter: ");
            char letterGuessed = Console.ReadLine()[0];
            bool right = false;
            for (int i = 0; i < Dictionary.newWord.Length; i++) {if (letterGuessed == Dictionary.newWord[i]){right = true;}}

            if (right)
            {
                GameBoard.printBoard(wrong);
                numLettersGuessed.Add(letterGuessed);
                lettersRight = WordMath.printWord(numLettersGuessed, Dictionary.newWord);
                Console.Write("\r\n");
                WordMath.lineMagic(Dictionary.newWord);
            }
            else
            {
                wrong += 1;
                numLettersGuessed.Add(letterGuessed);
                GameBoard.printBoard(wrong);
                lettersRight = WordMath.printWord(numLettersGuessed, Dictionary.newWord);
                Console.Write("\r\n");
                WordMath.lineMagic(Dictionary.newWord);
            }
        }
    }
}