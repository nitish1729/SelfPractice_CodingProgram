using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractice_CodingProgramCSharp
{
    public class One_EveonOrOdd
    {
        public  void check()
        {
            Console.WriteLine("Enter the firstnumber");
            int num1 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter the SecondNumber");
            // int num2 = int.Parse(Console.ReadLine());
            // int result = num1 % num2;
            // if (result == 0)
            // {
            //    Console.WriteLine("Entered number is even");
            // }
            // else
            // {

            //   Console.WriteLine("Entered number is Odd");

            // }
             Console.WriteLine(".....................................");
            if (num1 % 2 == 0)
            {
              Console.WriteLine("Entered number is even");
            }
            else
            {
              Console.WriteLine("Entered number is Odd");
            }
            Console.ReadLine();
        }
    }
}
