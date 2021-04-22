using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {

            Double num1;
            Double num2;
 
            Double avg;
            Console.WriteLine("Give me the first number");
            string i = Console.ReadLine();
            num1 = Convert.ToDouble(i);
            Console.WriteLine("Give me the second number");
            string j = Console.ReadLine();
            num2 = Convert.ToDouble(j);

            avg = (num1 + num2)/ 2;

            Console.WriteLine("The average is: "+ avg);

    }
  }
}
