using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {

            Double num1;
            Double num2;
            Double sum;
            Double min;
            Double mul;
            Double div;
            Console.WriteLine("Give me the first number");
            string i = Console.ReadLine();
            num1 = Convert.ToDouble(i);
            Console.WriteLine("Give me the second number");
            string j = Console.ReadLine();
            num2 = Convert.ToDouble(j);

            sum = num1 + num2;
            min = num1 - num2;
            mul = num1 * num2;
            div = num1 / num2;

            Console.WriteLine(i + " + " + j + " = " + sum);
            Console.WriteLine(i + " - " + j + " = " + min);
            Console.WriteLine(i + " * " + j + " = " + mul);
            Console.WriteLine(i + " / " + j + " = " + div);

    }
  }
}
