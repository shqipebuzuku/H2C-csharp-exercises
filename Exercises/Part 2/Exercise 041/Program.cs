using System;

namespace exercise_41
{
  class Program
  {
    public static void Main(string[] args)
    {
            int numb = 10;
            int pow;
            Console.WriteLine("Give a number:");
            string i = Console.ReadLine();
            numb = Convert.ToInt32(i);

            pow = numb * numb;

            Console.WriteLine(pow);
      
    }
  }
}
