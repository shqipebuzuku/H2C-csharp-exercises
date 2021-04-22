using System;

namespace exercise_22
{
  class Program
  {
    public static void Main(string[] args)
    {

            Double num1;
            Double num2;
            Double num3;
            Double avg;
            Console.WriteLine("Give me the first number");
            string i = Console.ReadLine();
            num1 = Convert.ToDouble(Convert.ToInt32(i));
            Console.WriteLine("Give me the second number");
            string j = Console.ReadLine();
            num2 = Convert.ToDouble(Convert.ToInt32(j));
            Console.WriteLine("Give me the third number");
            string k = Console.ReadLine();
            num3 = Convert.ToDouble(Convert.ToInt32(k));

            avg = (num1 + num2 + num3)/ 3;

            Console.WriteLine("The average is: "+ avg);

    }
  }
}
