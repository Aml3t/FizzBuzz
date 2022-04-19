using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many numbers you want:" + " ");
            int x = Int32.Parse(Console.ReadLine());
            int a = 3;
            int b = 5;
            int n; 
            // main algorithm
            for (n = 1; n <= x; n++)
            {
                if (n % a == 0 && n % b == 0)  // Numbers both divided by 3 and 5
                {
                    Console.WriteLine("The Number is: Fizz And Buzz");
                    continue;
                }
                if (n % a== 0) // Numbers divided by 3
                {
                    Console.WriteLine("The Number is: Fizz");
                    continue;
                }
                if (n % b == 0) // Numbers divided by 5
                {
                    Console.WriteLine("The Number is: Buzz");
                    continue;
                }
                
                Console.WriteLine("The number is: " + n);
            }
            Console.ReadKey();
        }
    }
}
