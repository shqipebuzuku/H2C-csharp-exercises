using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
            int num1;

            Console.WriteLine("Give your birthyear ");
            string i = Console.ReadLine();
            num1 = Convert.ToInt32(i);

            if (num1 < 1900) { Console.WriteLine("You're old!"); };

    }
  }
}
