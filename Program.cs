using System;

namespace MoPM_3
{
    using System;

    class Factorial
    {
        public static int RecursionExecute(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * RecursionExecute(n - 1);
        }

        public static int CycleExecute(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }

    class Fibonacci
    {
        public static int RecursionExecute(int n)
        {
            if (n == 0 || n == 1)
                return n;
            return RecursionExecute(n - 1) + RecursionExecute(n - 2);
        }

        public static int CycleExecute(int n)
        {
            if (n == 0 || n == 1)
                return n;

            int a = 0, b = 1, result = 0;
            for (int i = 2; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }
            return result;
        }
    }

    class DigitSumCalculator
    {
        public static int Execute(int n)
        {
            if (n == 0)
                return 0;
            return n % 10 + Execute(n / 10);
        }
    }

    class SumCalculator
    {
        public static int Execute(int a, int b)
        {
            if (b == 0)
                return a;
            return Execute(a ^ b, (a & b) << 1);
        }
    }

    class Program
    {
        // Метод для перевірки рівності значень
        static void assert(bool condition, string message)
        {
            if (!condition)
                throw new Exception(message);
        }
        static void Main()
        {
            // Задачі 1 та 2
            Console.WriteLine("Введіть кількість циклів рекурсії: ");
            int n = int.Parse(Console.ReadLine());

            int factorialRecursion = Factorial.RecursionExecute(n);
            int factorialCycle = Factorial.CycleExecute(n);

            Console.WriteLine($"Factorial ({n}) - Recursion: {factorialRecursion}");
            Console.WriteLine($"Factorial ({n}) - Cycle: {factorialCycle}");

            int fibonacciRecursion = Fibonacci.RecursionExecute(n);
            int fibonacciCycle = Fibonacci.CycleExecute(n);

            Console.WriteLine($"Fibonacci ({n}) - Recursion: {fibonacciRecursion}");
            Console.WriteLine($"Fibonacci ({n}) - Cycle: {fibonacciCycle}");

            // Перевірка для задач 1 і 2
            assert(factorialRecursion == factorialCycle, "Different values for Factorial");
            assert(fibonacciRecursion == fibonacciCycle, "Different values for Fibonacci");

            // Задача 3
            Console.WriteLine("Введіть одне число: ");
            int number = int.Parse(Console.ReadLine());
            int digitSum = DigitSumCalculator.Execute(number);

            Console.WriteLine($"Digit Sum ({number}): {digitSum}");

            // Задача 4
            Console.WriteLine("Введіть число (a): ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть число (b): ");
            int b = int.Parse(Console.ReadLine());
            int sum = SumCalculator.Execute(a, b);

            Console.WriteLine($"Sum of ({a}, {b}): {sum}");
        }
    }

}
