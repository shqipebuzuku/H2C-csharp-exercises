using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
            int numb = 0;
            while (numb != 42)
            {
                Console.WriteLine("Give a number");
                string i = Console.ReadLine();
                numb = Convert.ToInt32(i);

    }
  }
}
