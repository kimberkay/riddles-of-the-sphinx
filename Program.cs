using System;
using System.Collections.Generic;
using TheSphinx.Models;


namespace TheSphinx
{

public class Program
{
  public static void Main()
  {
    Riddle towel = new Riddle("What get's wet while drying?", "towel");


  Console.WriteLine("Answer the riddle of the sphinx or be doomed.");
  Console.WriteLine(towel.Question);
  string Answer = Console.ReadLine();
   if (towel.CheckAnswer(Answer))
   {
     Console.WriteLine("You are right!");
   }
   else 
   {
     Console.WriteLine("Very wrong. You are doomed.");
   }
  

} 
}
}