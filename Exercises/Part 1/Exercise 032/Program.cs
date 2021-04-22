using System;

namespace exercise_32
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Speak, friend and enter!");
            string i = Console.ReadLine();

            if (i == "Mellon" ) { Console.WriteLine("Welcome, friend"); };
            if (i != "Mellon") { Console.WriteLine("They've got a cave troll!"); };

    }
  }
}
