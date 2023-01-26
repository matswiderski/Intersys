using System;

namespace Intersys;
public class FindingPrimes
{
    public void Start()
    {
        uint T;
        bool correctFormat = UInt32.TryParse(Console.ReadLine(), out T);
        if (!correctFormat)
        {
            Console.WriteLine("Wrong T format");
            return;
        }

        int[] results = new int[T];
        try
        {
            for (int i = 0; i < T; i++)
            {
                int[] interval = GetInterval();
                results[i] = NumberOfPrime(interval[0], interval[1]);
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine();
        for (int i = 0; i < results.Length; i++)
            Console.WriteLine(results[i]);
    }

    private int[] GetInterval()
    {
        var interval = Console.ReadLine().Split(' ').Select(n => Int32.Parse(n)).ToArray();
        if (interval.Length != 2)
            throw new FormatException();
        if (!(interval[0] >= 1 && interval[0] <= interval[1] && interval[1] <= Math.Pow(10, 9) && (interval[1] - interval[0] <= Math.Pow(10, 5))))
            throw new ArgumentException();
        return interval;
    }

    private int NumberOfPrime(int m, int n)
    {
        int primeCounter = 0;
        for (int i = m; i <= n; i++)
        {
            if (i == 1)
                continue;
            int divider = 2;
            bool prime = true;
            while (divider < i)
            {
                if (i % divider == 0)
                {
                    prime = false;
                    break;
                }
                divider++;
            }
            if (prime)
                primeCounter++;
        }
        return primeCounter;
    }
}