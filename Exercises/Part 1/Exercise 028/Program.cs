using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
            int num1;

            Console.WriteLine("How old are you? ");
            string i = Console.ReadLine();
            num1 = Convert.ToInt32(i);

            if (num1 >= 18) { Console.WriteLine("You're an adult!"); }
            else { Console.WriteLine("You're under age!"); };

    }
  }
}
