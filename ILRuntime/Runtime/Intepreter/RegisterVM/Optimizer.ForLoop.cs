using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ILRuntime.Mono.Cecil;
using ILRuntime.Mono.Cecil.Cil;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Intepreter.OpCodes;

namespace ILRuntime.Runtime.Intepreter.RegisterVM
{
    partial class Optimizer
    {
        public static void ForLoop(List<CodeBasicBlock> blocks)
        {
            //程序集路径：C:\Users\Jason\Documents\GitHub\ILRuntime\TestCases\bin\Debug\TestCases.dll
            Console.WriteLine("开始优化For循环");
            int i = 1;
            foreach (var b in blocks)
            {
                Console.WriteLine();
                Console.WriteLine($"================");
                Console.WriteLine($"开始分析第{i}个Block");
                Console.WriteLine($"这个block有{b.NextBlocks.Count}个next");
                if (b.NextBlocks.Count > 1)
                {
                    foreach(var _b in b.NextBlocks)
                    {
                        Console.WriteLine($"Next = blocks[{blocks.IndexOf(_b)}]");
                    }
                }

                var result = LoopStartBlock(b,blocks);

                if (result != null)
                {
                    Console.WriteLine("是for循环");
                    Console.WriteLine($"For 循环从Block{blocks.IndexOf(result)+1}开始一直到Block{blocks.IndexOf(b)+1}结束");
                }
                else
                {
                    Console.WriteLine("并不是循环");
                }

                i++;

                var lst = b.FinalInstructions;//全部指令
                HashSet<int> canRemove = b.CanRemove;//需要删的index丢这里
            }
            Console.WriteLine("优化For循环结束");
        }


        private static CodeBasicBlock LoopStartBlock(CodeBasicBlock block,List<CodeBasicBlock> allBlocks)
        {
            //程序集路径：C:\Users\Jason\Documents\GitHub\ILRuntime\TestCases\bin\Debug\TestCases.dll

            HashSet<CodeBasicBlock> next = block.NextBlocks;

            if (next.Count == 1)//如果有1个next，那他肯定不是直接for的block，for的block有2个next，
                                 //一个是满足循环条件next block，一个是不满足循环条件的next block
            {
                return null;
            }

            //比如4个block
            /*
             * b1 -> b2 -> b3 -> b4
             *          / \ |
             *           |__|
             * 
             * 那么b3就有2个Next，分别为b2和b4
             * 所以只需要判断b2和b4是否有一个小于b3就ok
             */
            foreach(var b in next)
            {
               if(allBlocks.Contains(b) && allBlocks.IndexOf(b) < allBlocks.IndexOf(block))
                {
                    return b;
                }
            }

            return null;
        }
    }
}