using System;
using System.Collections.Generic;

namespace unit03_jumper.GameCalculations;
class Dictionary
{
    //Selects a random new word from a list, and then changes the newWord string to that word.

    public Dictionary()
    {

    }
    public static Random rand = new Random();
    static List<string> theDictionary = new List<string> {"coaxial", "dubious", "confligration", "tap", "forage", "zenith", "sprung", "yell"};
    static int index = rand.Next(theDictionary.Count);
    public static String newWord = theDictionary[index];
}