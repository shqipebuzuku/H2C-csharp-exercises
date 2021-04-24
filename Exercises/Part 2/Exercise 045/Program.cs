using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

            int numb1;
            int count = 0;

            Console.WriteLine("Give a positive number:");
            string i = Console.ReadLine();
            numb1 = Convert.ToInt32(i);

            while (count <= numb1) { Console.WriteLine(count); count++; };

    }
  }
}
