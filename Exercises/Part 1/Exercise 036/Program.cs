using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
            int numb = 100;
            int mul;
            while (numb != 0)
            {
                Console.WriteLine("Give a number");
                string i = Console.ReadLine();
                numb = Convert.ToInt32(i);
                if (numb < 0) { Console.WriteLine("That is negative!"); };
                if (numb > 0) { mul = numb * numb; Console.WriteLine(mul); };
            };


    }
  }
}
