using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPush
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Creating a stack
                Stack<int> originalStack = new Stack<int>();

                // Pushing elements to the original stack
                originalStack.Push(1);
                PrintStack(originalStack);

                originalStack.Push(2);
                PrintStack(originalStack);

                originalStack.Push(3);
                PrintStack(originalStack);

                // Popping elements from the original stack
                int poppedElement = originalStack.Pop();
                Console.WriteLine($"Popped element: {poppedElement}");
                PrintStack(originalStack);

                // Copying the stack to another stack
                Stack<int> copiedStack = new Stack<int>(originalStack);
                Console.WriteLine("Copied Stack:");
                PrintStack(copiedStack);

                // Clearing the original stack
                originalStack.Clear();
                Console.WriteLine("Original Stack after clearing:");
                PrintStack(originalStack);
            }

            static void PrintStack(Stack<int> stack)
            {
                Console.Write("Stack: ");
                foreach (var item in stack)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                Console.Read();
        }
        }

    }
