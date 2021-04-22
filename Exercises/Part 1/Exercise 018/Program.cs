using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {

            int num1;
            int num2;
            int num3;
            int sum;
            Console.WriteLine("Give me the first number");
            string i = Console.ReadLine();
            num1 = Convert.ToInt32(i);
            Console.WriteLine("Give me the second number");
            string j = Console.ReadLine();
            num2 = Convert.ToInt32(j);
            Console.WriteLine("Give me the third number");
            string k = Console.ReadLine();
            num3 = Convert.ToInt32(k);
            sum = num1 + num2 + num3;

            Console.WriteLine("The sum is "+sum);

    }
  }
}
