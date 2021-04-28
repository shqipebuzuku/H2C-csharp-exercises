using System;
using System.Collections.Generic;

namespace exercise_85
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] loginfo = { "alex", "sunshine", "emma", "haskell" };
            Console.WriteLine("Enter Username:");
            string user = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            string Pass = Console.ReadLine();
            int num = loginfo.Length;
            int flag = 0;
            for (int count = 0; count < num; count += 2)
            {
                if (user == loginfo[count]) { if (Pass == loginfo[count + 1]) { flag = 1; } }
            }
            if (flag == 0) { Console.WriteLine("Wrong username or password!"); }
            if (flag == 1) { Console.WriteLine("You have successfully logged in!"); }
        }
    }
}

