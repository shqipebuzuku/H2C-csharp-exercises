using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give the first string:");
            string i = Console.ReadLine();
            Console.WriteLine("Give the second string:");
            string j = Console.ReadLine();

            if (i == j ) { Console.WriteLine("Echo!"); };
            if (i != j) { Console.WriteLine("Nope!"); };


    }
  }
}
