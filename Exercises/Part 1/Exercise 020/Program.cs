using System;

namespace exercise_20
{
  class Program
  {
    public static void Main(string[] args)
    {

            int num1;
            int num2;
 
            int mul;
            Console.WriteLine("Give me the first number");
            string i = Console.ReadLine();
            num1 = Convert.ToInt32(i);
            Console.WriteLine("Give me the second number");
            string j = Console.ReadLine();
            num2 = Convert.ToInt32(j);

            mul = num1 * num2 ;

            Console.WriteLine(i + " * " + j +" = "+ mul);

    }
  }
}
