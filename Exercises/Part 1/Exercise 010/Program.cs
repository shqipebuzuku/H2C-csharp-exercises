using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
          
            Console.WriteLine("I will tell a story, but first:");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your profession?");
            string prof = Console.ReadLine();
            Console.WriteLine("In a galaxy far far away...");
            Console.WriteLine("There was a " + prof + " called " + name + "...");
            Console.WriteLine(name + " was the best "+prof + " known in the galaxy...");
            Console.WriteLine("But others in the galaxy didn't know what being a "+prof+" really meant...");
            Console.WriteLine("So " + name + " was pushed to the dark side...");
            Console.WriteLine("Where "+name+" continued to be a "+prof+"...");
            Console.WriteLine("Using the knowledge for evil...");

        }
    }
}
