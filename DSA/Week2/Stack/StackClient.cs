using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Stack
{
    internal class StackClient
    {
        public static void Run()
        {
            Console.WriteLine("Stack: - for pop");
            IStack<string> stack = new ResizableArrayStack();
            while (true)
            {
                string? input = Console.ReadLine();
                if (input == "-")
                {
                    if (stack.isEmpty()) continue;
                    Console.WriteLine($"=> {stack.pop()}");
                }
                else if (input == null) continue;
                else stack.push(input);
            }
        }

        public static void RunWithMax()
        {
            Console.WriteLine("StackWithMax: - for pop, = for max");
            StackWithMax stack = new StackWithMax();
            while (true)
            {
                string? inputString = Console.ReadLine();

                if (inputString == "-")
                {
                    if (stack.isEmpty()) continue;
                    Console.WriteLine($"=> {stack.pop()}");
                }
                else if(inputString == "=")
                {
                    if (stack.isEmpty()) continue;
                    Console.WriteLine($"=> {stack.max()}");
                }
                else if (inputString == null) continue;
                else if(int.TryParse(inputString,out int input))
                     stack.push(input);
            }
        }
    }
}
