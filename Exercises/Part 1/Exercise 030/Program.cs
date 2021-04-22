using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
            int num1;


            Console.WriteLine("Give your score");
            string i = Console.ReadLine();
            num1 = Convert.ToInt32(i);


            if (num1 < 0 ) { Console.WriteLine("Impossible!"); };
            if (49 >= num1 && num1 >= 0) { Console.WriteLine("Failed"); };
            if (59 >= num1 && num1 >= 50) { Console.WriteLine("Grade 1"); };
            if (69 >= num1 && num1 >= 60) { Console.WriteLine("Grade 2"); };
            if (79 >= num1 && num1 >= 70) { Console.WriteLine("Grade 3"); };
            if (89 >= num1 && num1 >= 80) { Console.WriteLine("Grade 4"); };
            if (100 >= num1 && num1 >= 90) { Console.WriteLine("Grade 5"); };
            if (num1 > 100) { Console.WriteLine("Outstanding!"); };

    }
  }
}
