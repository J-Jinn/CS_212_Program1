using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LgLg_n
{
    /**
     * Simple program to calculate floor(log(log(n))) with base 2.
     * 
     * CS - 212 Data Structures and Algorithms
     * Section B
     * Professor Plantinga
     * Date: 9-15-18
     * Author: Joseph Jinn
     * */

    class Program
    {
        /// <summary>
        /// Main method.
        /// Displays welcome message, asks for user input, and displays result
        /// of floor(log(log(n))) base 2 calculation to the console.
        /// </summary>
        /// <param name="args"></param>
        /// 
        static void Main(string[] args)
        {
            // Local variables.
            double number;

            Console.WriteLine("Program 1: floor(Lg Lg n)\n\n");

            // Infinite loop to keep console open indefinitely.
            while (true)
            {
                Console.WriteLine("Note: Domain of log(log(n)) base 2 is n > 1");
                Console.WriteLine("Enter -1 to exit the program!");
                Console.WriteLine("Please enter a valid real number, n > 1: ");

                // Read user input.
                try
                {
                    number = double.Parse(Console.ReadLine());
                }
                catch (Exception excpt)
                {
                    Console.WriteLine("\nUser did not enter a real number, n > 1!");
                    Console.WriteLine("Please try again!\n");
                    continue;
                }

                // Exit console application.
                if (number == -1.0)
                {
                    return;
                }
                // Check user input is in domain of log(log(n)) base 2.
                // (we are excluding complex numbers)
                if (number <= 1)
                {
                    Console.WriteLine("\nUser did not enter a real number, n > 1!");
                    Console.WriteLine("Please try again!\n");
                    continue;
                }

                // Calculate floor(log(n))
                int logNumber = Log(number);

                // Debug statement.
                Console.WriteLine("floor(log(n)) is: {0}", logNumber);

                // Check if floor(log(n)) is zero
                if (logNumber == 0)
                {
                    Console.WriteLine("\nfloor(log(n)) is zero: cannot take floor(log(floor(log(n))))");
                    Console.WriteLine("Domain of logarithm base 2 is n > 0\n");
                }

                // Calculate floor(log(floor(log(n))))
                int logLogNumber = Log(logNumber);

                // Display the result.
                Console.WriteLine("floor(log(floor(log(n)))) => {0}\n\n", logLogNumber);

                // TODO: do we need to calculate the exact log(n) value first before calculating floor(log(log(n)))?
                // Or do we actually calculate floor(log n), then floor(log(floor(log(n))))?
                // This would make things more difficult.
            }
        }

        /// <summary>
        /// Method to calculate the floor'ed logarithm base 2 of a number.
        /// </summary>
        /// <param name="n">A real number</param>
        /// <returns>i = floor(lg(n))</returns>
        /// 
        static int Log(double n)
        {
            // Local variables.
            int i = -1;

            // Algorithm to calculate floor(log(n))
            while (n >= 1.0)
            {
                n /= 2.0;
                i++;
            }
            return i;
        }
    }
}
