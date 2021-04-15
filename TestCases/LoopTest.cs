using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases
{
    class LoopTest
    {
        public static void Test1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Test2()
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

        public static void Test3()
        {
            int i = 10;
            while (i > 0)
            {
                i--;
                Console.WriteLine(i);
            }
        }

        public static void Test4()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i < 5)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"{i}大于5");
                }
            }
        }

        public static void Test5()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i >3)
                {
                    goto End;
                }
            }
        End:
            Console.WriteLine("goto使得循环结束了");
        }

        public static void Test6()
        {
            int a = 100;
            if (a / 10 == 0)
            {
                Console.WriteLine("a / 10 == 0");
            }
            else
            {
                Console.WriteLine("a / 10 != 0");
            }
        }

        public static void Test7()
        {
            for (int a = 0; a < 5; a++)
            {
                Console.WriteLine($"a={a}");
            }
            for (int b = 0; b < 10; b++)
            {
                Console.WriteLine($"b={b}");
            }
        }

        private static int test8Num;

        public static void Test8()
        {
            test8Num = 10;
            if (test8Num > 0)
            {
                goto Dec;
            }
        Dec:
            test8Num--;
        }
    }
}
