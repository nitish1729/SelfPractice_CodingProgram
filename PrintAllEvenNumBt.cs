using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfpractice_codingprogramcsharp
{
    public class PrintAllEvenNum
    {
        public  void CheckEvenNum()

        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    //continue statement is used to skip over the execution part of the loop
                    continue;
                }

                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
