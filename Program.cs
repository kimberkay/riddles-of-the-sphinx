using System;
using System.Collections.Generic;


namespace TheSphinx
{

public class Program
{
  public static void Main()
  {
    Riddle towel = new Riddle("What get's wet while drying?","towel");


  Console.WriteLine("To Answer the riddle of the sphinx hit or be doomed.");
  Console.WriteLine(towel.GetQuestion);
  string Answer = Console.ReadLine();
  

} 
}
}