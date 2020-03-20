using System;

namespace guessgame
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Hello Player");
      int guessCounter = 0;
      int numToFind = randNum();
      bool notGuessed = true;

      while (notGuessed)
      {
        Console.WriteLine("Guess a number between 1 and 100");
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
          Console.WriteLine("");
          Console.WriteLine($"{playerGuessInt} is too High, try a lower number");
        }
        else if (playerGuessInt < numToFind)
        {
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
