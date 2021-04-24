using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {
            int numb1;
            int count = 100;

            Console.WriteLine("Give a positive number:");
            string i = Console.ReadLine();
            numb1 = Convert.ToInt32(i);

            while (numb1 <= count) { Console.WriteLine(numb1); numb1++; };

    }
  }
}
