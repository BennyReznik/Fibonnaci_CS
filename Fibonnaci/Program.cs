using System;
using System.Collections.Generic;

namespace Fibonnaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write($"Simple Loop: {Environment.NewLine}");
            FibonnaciSimpleForLoop(number);
            Console.Write($"{Environment.NewLine}Recursion: {Environment.NewLine}");
            FibonacciUsingRecursion(0, 1, 1, number);
            Console.Write($"{Environment.NewLine}Yield: {Environment.NewLine}");
            foreach (int n in FibonacciUsingYield(number))
            {
                Console.Write(n + " ");
            }
            Console.Write(Environment.NewLine);
            Console.ReadLine();
        }

        static void FibonnaciSimpleForLoop(int number)
        {
            int n1 = 0, n2 = 1, n3, i;
            
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }

        static void FibonacciUsingRecursion(int a, int b, int counter, int number)
        {
            Console.Write(a + " ");
            if (counter < number) FibonacciUsingRecursion(b, a + b, counter + 1, number);
        }

        static IEnumerable<int> FibonacciUsingYield(int number)
        {
            int prev = -1;
            int next = 1;
            for (int i = 0; i < number; i++)
            {
                int sum = prev + next;
                prev = next;
                next = sum;
                yield return sum;
            }
        }
    }
}
