using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
            int numb1;
            
            Console.WriteLine("What number?");
            string i = Console.ReadLine();
            numb1 = Convert.ToInt32(i);

            PrintUntilNumber(numb1); 
    }

   public static void PrintUntilNumber(int a)
    {
            int count;
            for (count = 1; count <= a; count++) {  
            Console.WriteLine(count);
            };
    }
  }
}
