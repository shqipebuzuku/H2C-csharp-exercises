using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

            int numb1;
            int numb2;

            Console.WriteLine("Give first number:");
            string i = Console.ReadLine();
            numb1 = Convert.ToInt32(i);

            Console.WriteLine("Give second number:");
            string j = Console.ReadLine();
            numb2 = Convert.ToInt32(j);

            double sqr = Math.Sqrt(numb1+numb2);

            Console.WriteLine(sqr);
    
    }
  }
}
