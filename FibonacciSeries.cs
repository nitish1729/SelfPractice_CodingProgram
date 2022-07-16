using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractice_CodingProgramCSharp
{
    public class FibonacciSeries
    {
        public void fibonacci()
        {
            Console.WriteLine("a series of numbers in which each number ( Fibonacci number ) is the sum of the two preceding numbers. " +
             "The simplest is the series 1, 1, 2, 3, 5, 8, etc.");
            int a = 0;
            int b = 1;
            int c;

            Console.WriteLine("{0}",a );
            Console.WriteLine("{0}", b);
            for (int i  = 0; i  < 10; i ++)
            {
                c = a + b;
                Console.WriteLine("{0}", c);
                a = b;
                b = c;
 
            }
            Console.ReadLine();
        }

    }
}
