using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {
            int numb = 10;
            int count = 0;
            int count2 = 0;
            while (numb != 0)
            {
                Console.WriteLine("Give a number:");
                string i = Console.ReadLine();
                numb = Convert.ToInt32(i);
                if (numb != 0) { count=count+numb; count2++; };
                
            };

            Console.WriteLine("Total sum of numbers: " + count);
            Console.WriteLine("Total amount of numbers: " + count2);
    }
  }
}
