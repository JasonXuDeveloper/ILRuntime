using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases
{
    class ForTest
    {
        public static void Test1()
        {
            /*
             * 判断结果正确
             *
                开始分析第3个Block
                这个block有2个next
                Next = blocks[1]
                Next = blocks[3]
                是for循环
                For 循环从Block2开始一直到Block3结束
             */
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Test2()
        {
            /*
            * 判断结果正确
            *
                开始分析第6个Block
                这个block有2个next
                Next = blocks[1]
                Next = blocks[6]
                是for循环
                For 循环从Block2开始一直到Block6结束
            */

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
    }
}
