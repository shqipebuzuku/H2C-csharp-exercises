using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
            int numb = 100;
            int count = 0;
            while (numb != 0)
            {
                Console.WriteLine("Give a number:");
                string i = Console.ReadLine();
                numb = Convert.ToInt32(i);
                if (numb != 0) { count++; };
                
            };

            Console.WriteLine("Total amount of numbers: " + count);

    }
  }
}
