using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//welcome user
//prompt user for radius
//display error for invalid data
//Create Circle Object
//calculate the circumference and area
//display info as 2 decimal places
//prompt user to continue
//say goodbye 
//display number of circles built

namespace Lab9
{
    class CircleApp
    {

        public CircleApp()
        {

        }

        public static void Welcome()
        {
            Console.WriteLine("Welcome to the Circle Tester.");
        }

        public static double GetRadius()
        {
            Console.WriteLine("Enter a radius:");
            double radius = double.Parse(Console.ReadLine());
            //user validation here -- struggling on this, Ask Tommy
            return radius;
        }
        public static void PrintStats(string fc, string fa)
        {
            Console.WriteLine("Circumference: " + fc);
            Console.WriteLine("Area: " + fa);
        }

        public static void Goodbye()
        {
            Console.WriteLine("Goodbye");
        }

        public static void FinalCount(int i)
        {
        Console.WriteLine("You created " +i+ " circle object(s)");
        }


        public static bool Continue()
        {
            Console.WriteLine("Continue? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }

            return goOn;
        }

        
    }
}
