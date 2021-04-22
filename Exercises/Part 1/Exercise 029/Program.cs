using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
            int num1;
            int num2;

            Console.WriteLine("Give the first number ");
            string i = Console.ReadLine();
            num1 = Convert.ToInt32(i);

            Console.WriteLine("Give the second number ");
            string j = Console.ReadLine();
            num2 = Convert.ToInt32(j);

            if (num1 > num2) { Console.WriteLine("The larger number is " + i + "!"); };
            if (num1 < num2) { Console.WriteLine("The larger number is " + j + "!"); };
            if (num1 == num2) { Console.WriteLine("The numbers are equal!"); };

    }
  }
}
