using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter_types_1._3
{
    class Program
    {
        // Method 1: Using 'ref' to calculate the area of a square
        static void CalculateArea(ref int side)
        {
            int area = side * side;
            Console.WriteLine($"Area of square (ref): {area}");
        }
    
     /*   // Method 2: Using 'out' to calculate the area of a square
        static void CalculateArea(out int side)
        {
            side = 5; // Assigning a value to 'side'
            int area = side * side;
            Console.WriteLine($"Area of square (out): {area}");
        }
        // Method 3: Using 'in' to calculate the area of a square
        static void CalculateArea(in int side)
        {
            int area = side * side;
            Console.WriteLine($"Area of square (in): {area}");
        }
        // Method 4: Using 'params' to calculate the area of multiple squares
        static void CalculateArea(params int[] sides)
        {
            foreach (var side in sides)
            {
                int area = side * side;
                Console.WriteLine($"Area of square (params): {area}");
            }
        }
*/

        // Method 5: Using an optional parameter to calculate the area of a square
        static void CalculateArea(int side = 4)
        {
            int area = side * side;
            Console.WriteLine($"Area of square (optional): {area}");
        }

        static void Main(string[] args)
        {
            int sideLength = 3;

            // Uncomment one method call at a time to observe ambiguity in method overloading.

            CalculateArea(ref sideLength);  // Ambiguous between 'ref' and 'optional'
            // CalculateArea(out sideLength);  // Ambiguous between 'out' and 'optional'
            // CalculateArea(in sideLength);   // Ambiguous between 'in' and 'optional'
            // CalculateArea(sideLength);      // Ambiguous between 'optional', 'in', and 'params'
        }
    }
}