using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
            int num1;

            Console.WriteLine("Give a number ");
            string i = Console.ReadLine();
            num1 = Convert.ToInt32(i);

            if (num1 >= 0) { Console.WriteLine("Positive"); }
            else { Console.WriteLine("Negative"); };

    }
  }
}
