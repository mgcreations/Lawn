using System;

namespace Lawn
{
    class Program
    {
        static void Main(string[] args)
        {
            const double SEASON = 20;
            int length, width, area;
            double total;

            Console.Write("Enter the lawn length: ");
            length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the lawn width: ");
            width = Convert.ToInt32(Console.ReadLine());

            area = length * width;

            if (area <= 399)
            {
                total = 25 * SEASON;
                Console.WriteLine("Weekly Fee: R25, total fee {0}", total.ToString("C"));
            }

            else if (area >= 400 && area <= 599)
            {
                total = 35 * SEASON;
                Console.WriteLine("Weekly Fee: R35, total fee {0}", total.ToString("C"));
            }

            else if (area >= 600) 
            {
                total = 50 * SEASON;
                Console.WriteLine("Weekly Fee: R50, total fee {0}", total.ToString("C"));
            }
        }
    }
}
