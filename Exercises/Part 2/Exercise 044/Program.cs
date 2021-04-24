using System;

namespace exercise_44
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
            if (numb1 < numb2) { Console.WriteLine(numb1+ " is less than " + numb2); };
            if (numb1 > numb2) { Console.WriteLine(numb1 + " is grEater than " + numb2); };
            if (numb1 == numb2) { Console.WriteLine(numb1 + " is equal to " + numb2); };
            

    }
  }
}
