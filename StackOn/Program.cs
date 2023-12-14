using StackOn.Exceptions;
using System;

namespace StackOnList
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack<int> stack = new Stack<int>(5);
                stack.Push(1);
                stack.Push(2);
                stack.Push(5);
                stack.Push(3);

                stack.Sort();
                Console.WriteLine(stack[0]);
                Console.WriteLine(stack);
                foreach (int i in stack) Console.WriteLine(i);
                Stack<double> stack2 = new Stack<double>(5);
                stack2.Push(3.5);
                stack2.Push(2.5);
                stack2.Push(1.5);
                stack2.Push(1);
                stack2.Sort();
                Console.WriteLine(stack2);
                foreach (double i in stack2) Console.WriteLine(i);
            }
            catch (IndexValueException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}