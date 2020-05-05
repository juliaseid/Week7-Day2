using System;
using System.Collections.Generic;

public class Triangle {

  public static String checkSides(int x, int y, int z){
    if (x+y <= z || y+z <= x || z+x <= y) {
      return "That won't make a triangle - the sides can't reach each other!";
    } else if (x == y && y == z) {
      return "That's an equilateral triangle! So even!";
    } else if (x == y || x == z || y == z) {
      return "You made an isoceles triangle! Is it tall and narrow or wide and flat?";
    } else {
      return "Way to think different! You made a scalene triangle, with every side different!";
    }
  }
  
  public static void Main(){
    Console.WriteLine("This is a Triangle Checker. Please enter 3 numbers 1 at a time to represent the 3 sides of a triangle.");
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    int z = int.Parse(Console.ReadLine());
    Console.WriteLine(checkSides(x, y, z));
  }
}