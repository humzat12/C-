using System;
//Student Name and Number: Humza Tareen. 301272082
//Assignment 4 Question 5 
namespace Assignment4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter a day.(Ex. Sun = Sunday)");
            String day = Convert.ToString(Console.ReadLine());


            switch (day)
            {
                case "sun":
                    Console.WriteLine("Home");
                    break;

                case "Mon":
                    Console.WriteLine("Work");
                    break;

                case "Tue":
                    Console.WriteLine("Work");
                    break;

                case "Wed":
                    Console.WriteLine("Home");
                    break;

                case "Thu":
                    Console.WriteLine("Work");
                    break;

                case "Fri":
                    Console.WriteLine("Work");
                    break;

                case "Sat":
                    Console.WriteLine("Work");
                    break;

                default:
                    Console.WriteLine("Incorrect entry please try again");
                    break;




            }
            Console.ReadLine();
        }
    }
}
