using System;
using System.Linq;

public class Palindrome {

  public static bool checkPal(string input){
    char[] charArray = input.Where(c => (char.IsLetterOrDigit(c) || 
                                        char.IsWhiteSpace(c) || 
                                        c == '-')).ToArray(); 
    input = new string(charArray);
    int j = charArray.Length - 1;
    for (int i=0; i<charArray.Length; i++) {
      if (charArray[i] != charArray[j]){
        return false;
      } 
      j--;
    }
    return true;
  }
  public static void Main(){
    Console.WriteLine("Please enter a palindrome:");
    string input = Console.ReadLine();
    if (checkPal(input)){
      Console.WriteLine("That's a pal! :D");
    } else {
      Console.WriteLine("Ain't a real pal. :(");
    }
  }
}