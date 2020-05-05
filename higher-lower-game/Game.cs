using System;

class NumberGuesser
{

  static void Main()
  {
    Console.WriteLine("Do you want to play the number guessing game?");
    string response = Console.ReadLine();
    bool play = false;
    if (response == "no") {
      Console.WriteLine("Aww what a shame...");
    } else if (response == "yes") {
      play = true;
      Console.WriteLine("Great! Think of a number between 1 and 100, exclusive");
      int guess = 50;
      string answer, end;
      while (play == true) {
      Console.WriteLine("Is your number higher than " + guess + "?");
      answer = Console.ReadLine().Trim().ToLower();
      if (answer == "yes"){
        guess += guess / 2; 
      } else if (answer == "no") {
        guess /= 2;
      } else if (answer == "correct") {
        Console.WriteLine("Yay! I guessed it! Do you want to play again?");
        end = Console.ReadLine();
        if (end == "yes") {
          guess = 50;
        } else {
          play = false;
          }
      } else {
          Console.WriteLine("I'm sorry, I only understand: yes, no, correct. Please only enter one of those messages.");
        }
      }
    }
  }
}