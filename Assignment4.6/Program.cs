using System;
//Student Name and Number: Humza Tareen. 301272082 
//Assignment 4 Question 6
namespace Assignment4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int pineTable = 100;
            const int oakTable = 225;
            const int mahoganyTable = 310; 

            Console.WriteLine("Hello, please choose between Pine, Oak, or Mahogany");
            String Selection = Console.ReadLine().ToLower(); 

            switch (Selection)
            {
                case "pine":
                    Console.WriteLine("The cost of a pine table will be: $" + pineTable);
                    break;

                case "oak":
                    Console.WriteLine("The cost of a Oak table will be: $" + oakTable);
                    break;

                case "mahogany":
                    Console.WriteLine("The cost of a Mahogany table will be: $" + mahoganyTable);
                    break;

                default:
                    Console.WriteLine("Incorrect input please try again");
                    break;

            }
            Console.ReadLine();
        }
    }
}
