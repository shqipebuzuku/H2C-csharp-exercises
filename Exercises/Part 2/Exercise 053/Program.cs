using System;

namespace exercise_53
{
   class Program
    {
        static void Main(string[] args)
        {
            int numb1;
            int numb2;
            
            Console.WriteLine("Give numerator");
            string i = Console.ReadLine();
            numb1 = Convert.ToInt32(i);

            Console.WriteLine("Give denominator");
            string j = Console.ReadLine();
            numb2 = Convert.ToInt32(j);

            Division(numb1,numb2); 
            
        }
        public static void Division(int numerator, int denominator)
        {
            double div;
            double num = Convert.ToDouble(numerator);
            double den = Convert.ToDouble(denominator);

            div = num / den;
            Console.WriteLine("The result of the division is:");
            Console.WriteLine(div);
            
        }
    }
}
