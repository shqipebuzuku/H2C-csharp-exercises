using System;

namespace exercise_58
{
    class Program
    {

        public static void Main(String[] args)
        {
            int numb1;
            int numb2;


            Console.WriteLine("Give number");
            string i = Console.ReadLine();
            numb1 = Convert.ToInt32(i);

            Console.WriteLine("Give number");
            string j = Console.ReadLine();
            numb2 = Convert.ToInt32(j);

            int answer = Smallest(numb1, numb2);
            Console.WriteLine("Smallest: " + answer);
        }

        public static int Smallest(int number1, int number2)
        {
            int result = 0;
            if(number1 < number2) { result = number1; }
            if(number2 < number1) { result = number2; }

            return result;

        }
}
