using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractice_CodingProgramCSharp
{
    public class FindLargerNum
    {
        public  void GreaterNum()
        {
            Console.WriteLine("Enter Num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Num3");
            int num3 = int.Parse(Console.ReadLine());
            // if (num1 > num2)
            // {
            //    Console.WriteLine("Number1 is greater");
            // }
            // else
            // {
            //    Console.WriteLine("Number2 is greater");
            // }
            // if (num1 > num2 && num1 > num3)
            // {
            // }
            // else if (num2 > num3 && num2 > num1)
            // {
            //    Console.WriteLine("Number2 is greater");
            // }
            // else
            // {
            //    Console.WriteLine("Number3 is greater");
            // }
            // Console.WriteLine(".............................");

            if (num1 > num2)
            {
                // nested if condition
                if (num1 > num3)
                {
                    Console.WriteLine("Number1 is greater");
                }
                else
                {
                    Console.WriteLine("Number3 is greater");

                }
            }
            else
            {

                if (num2 > num3)
                {
                    Console.WriteLine("Number2 is greater");
                }
                else
                {
                    Console.WriteLine("Number3 is greater");
                }
            }
            Console.ReadLine();
        }
    }
}
