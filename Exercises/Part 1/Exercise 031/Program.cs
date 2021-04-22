using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
            int num1;
            int mod;


            Console.WriteLine("Give an integer");
            string i = Console.ReadLine();
            num1 = Convert.ToInt32(i);

            mod = num1 % 2;

            if (mod == 0 ) { Console.WriteLine("It is even."); };
            if (mod == 1) { Console.WriteLine("It is odd."); };

    }
  }
}
