using System;

namespace CommonElements
{
    class CommonElements
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int fib = GetFibonacci(n);
            Console.WriteLine(fib);
        }
        public static int GetFibonacci(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
        
    }
}