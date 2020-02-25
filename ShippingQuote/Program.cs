using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");

            Console.Write("Package Weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            if (weight <= 50)
            {
                Console.Write("Package width: ");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.Write("Package height: ");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.Write("Package length: ");
                double length = Convert.ToDouble(Console.ReadLine());

                if ((width + height + length) <+ 50)
                {
                    double quote = width * height * length / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString());
                }
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                }
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
            }

            Console.WriteLine("Thank you");
            Console.Read();
        }
    }
}
