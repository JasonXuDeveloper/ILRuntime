using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases
{
    class ForTest
    {
        public static void TestForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i > 5)
                {
                    Console.WriteLine("比5大");
                }
                else
                {
                    Console.WriteLine("比5小");
                }
            }
        }
    }
}
