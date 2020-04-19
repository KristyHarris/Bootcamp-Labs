using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Calculator!");
            Console.WriteLine("");
            string response;

            do
            {
                Console.Write("Enter Length: ");
                var length = float.Parse(Console.ReadLine());

                Console.Write("Enter Width: ");
                var width = float.Parse(Console.ReadLine());

                var area = (length * width);
                Console.WriteLine("Area: " + area);

                var perimeter = (length * 2) + (width * 2);
                Console.WriteLine("Perimeter: " + perimeter);

                Console.WriteLine("Continue? y/n");
                response = Console.ReadLine();
            } while (response == "y" || response == "Y");

            Console.WriteLine("Goodbye!");
        }
    }
}
