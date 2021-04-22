using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give a string:");
            string sent = Console.ReadLine();
            
            int num1;
            Console.WriteLine("Give an integer:");
            string i = Console.ReadLine();
            num1 = Convert.ToInt32(i);

            Double num2;
            Console.WriteLine("Give me a double:");
            string j = Console.ReadLine();
            num2 = Convert.ToDouble(j);

            Boolean num3;
            Console.WriteLine("Give me a boolean:");
            string k = Console.ReadLine();
            num3 = Convert.ToBoolean(k);

            Console.WriteLine("Your string: " + sent);
            Console.WriteLine("Your integer: "+num1);
            Console.WriteLine("Your double: " + num2);
            Console.WriteLine("Your boolean: " + num3);


    }
  }
}
