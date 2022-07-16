using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractice_CodingProgramCSharp
{
    public class Swapping
    {
        public void swap()
        {
            Console.WriteLine("Enter the 1st number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2st number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before swipping Value of a ={0}, b = {1}",a , b);
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swipping Value of a ={0}, b = {1}", a, b);
            Console.ReadLine();
        }
    }
}
