using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {
            int num1;

            Console.WriteLine("Your speed: ");
            string i = Console.ReadLine();
            num1 = Convert.ToInt32(i);

            if (num1 > 120) { Console.WriteLine("Speeding!"); };
      
    }
  }
}
