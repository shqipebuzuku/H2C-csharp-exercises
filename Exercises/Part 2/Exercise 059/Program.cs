using System;

namespace exercise_59
{
    class Program
    {

        public static void Main(String[] args)
        {
            int numb1;
            int numb2;
            int numb3;

            Console.WriteLine("Give number");
            string i = Console.ReadLine();
            numb1 = Convert.ToInt32(i);

            Console.WriteLine("Give number");
            string j = Console.ReadLine();
            numb2 = Convert.ToInt32(j);

            Console.WriteLine("Give number");
            string k = Console.ReadLine();
            numb3 = Convert.ToInt32(k);

            int answer = Greatest(numb1, numb2, numb3);
            Console.WriteLine("GrEatest: " + answer);
        }

        public static int Greatest(int number1, int number2, int number3)
        {
            int result = 0;
            if(number1 > number2) 
            {
                if (number1 > number3) { result = number1; }
            }

            if (number2 > number1)
            {
                if (number2 > number3) { result = number2; }
            }

            if (number3 > number1)
            {
                if (number3 > number2) { result = number3; }
            }

            return result;

        }

    }
}
