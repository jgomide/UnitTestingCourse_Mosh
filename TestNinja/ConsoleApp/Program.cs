using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var stack = new Stack();
            
            stack.Push(100);
            stack.Push(101);
            stack.Push(102);

            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Peek());

            stack.Pop();
            
            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Peek());
        }
    }
}