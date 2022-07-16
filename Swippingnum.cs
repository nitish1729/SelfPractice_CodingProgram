using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractice_CodingProgramCSharp
{
    public class Swippingnum
    {
      public void Swap()
      { 
        Console.WriteLine("Enter the 1st number");
            int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the 2st number");
            int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Before swipping Value of a ={0}, b = {1}",a , b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swipping Value of a ={0}, b = {1}", a, b);
            Console.ReadLine();

        }

    }
}
