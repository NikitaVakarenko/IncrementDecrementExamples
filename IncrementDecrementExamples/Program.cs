using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementDecrementExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example of incrementing and decrementing a variable
            int number = 5;
            number++; // Incrementing by 1
            Console.WriteLine("After incrementing: " + number); // Output: 6

            number--; // Decrementing by 1
            Console.WriteLine("After decrementing: " + number); // Output: 5
            Console.ReadKey();

            ++number; // Incrementing by 1 again
            Console.WriteLine("After pre-incrementing: " + number); // Output: 6
            --number; // Decrementing by 1 again
            Console.WriteLine("After pre-decrementing: " + number); // Output: 5
            Console.ReadKey();

            //Comparison operators | Relational operators
            int a = 10;
            int b = 20;
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
            Console.ReadKey();

        }
    }
}
