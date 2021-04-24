using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
            int numb1 = 0;
            int refe = -1;
            int sum = 0;
            int count = 0;
            double avg = 0;
            int even = 0;
            int odd = 0;
            int check;

            while (numb1 != refe)
            {
                
                Console.WriteLine("Give Number:");
                string i = Console.ReadLine();
                numb1 = Convert.ToInt32(i);
                if (numb1 != -1)
                {
                    count++;
                    sum = sum + numb1;
                    avg = sum / count;
                    check = numb1 % 2;
                    if (check == 0) { even++; };
                    if (check != 0) { odd++; };
                }
            };
            Console.WriteLine("Thx! Bye!");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Numbers: " + count);
            Console.WriteLine("Average: " + avg);
            Console.WriteLine("Even: " + even);
            Console.WriteLine("Odd: " + odd);
 
    }
  }
}
