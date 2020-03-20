using System;

namespace guessgame
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      Console.WriteLine(@"
 ________         _____                   _____              
/_  __/ /  ___   / ___/_ _____ ___ ___   / ___/__ ___ _  ___ 
 / / / _ \/ -_) / (_ / // / -_|_-<(_-<  / (_ / _ `/  ' \/ -_)
/_/ /_//_/\__/  \___/\_,_/\__/___/___/  \___/\_,_/_/_/_/\__/ 
                                                             
");

      Console.WriteLine("Hello Player");
      int guessCounter = 0;
      int numToFind = randNum();
      bool notGuessed = true;
      int minVal = 1;
      int maxVal = 100;

      while (notGuessed)
      {
        Console.WriteLine($"Guess a number between {minVal} and {maxVal}");
        string playerGuessStr = Console.ReadLine();
        int playerGuessInt = Int32.Parse(playerGuessStr);
        guessCounter++;

        if (playerGuessInt == numToFind)
        {
          Console.WriteLine("");
          Console.WriteLine($"That is correct -- you guesed it in {guessCounter} tries");
          notGuessed = false;
          break;
        }
        else if (playerGuessInt > numToFind)
        {
          maxVal = playerGuessInt;
          Console.WriteLine("");
          Console.WriteLine($"{playerGuessInt} is too High, try a lower number");
        }
        else if (playerGuessInt < numToFind)
        {
          minVal = playerGuessInt;
          Console.WriteLine("");
          Console.WriteLine($"{playerGuessInt} is too Low, try a higher number");
        }
      }

      //random number generator 1 to 100
      int randNum()
      {
        Random rnd = new Random();
        int randNum = rnd.Next(1, 101);
        return randNum;
      }//end of randNum

    } //end of main
  }//end of Program
}//end of namespace
