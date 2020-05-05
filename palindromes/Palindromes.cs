using System;
using System.Collections.Generic;

public class Palindrome {

  public static bool checkPal(string input){
    input = input.Replace(" ", "");
    Console.WriteLine(input);
    char[] charArray = input.ToCharArray();
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
    Console.WriteLine("Please enter a palindrome");
    string input = Console.ReadLine();
    Console.WriteLine(checkPal(input));
  }
}