using System;

class Task4
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        bool[] primes = new bool[n + 1];
        for (int i = 0; i <= n; i++)
            primes[i] = true;

        primes[0] = false;
        primes[1] = false;

        for (int p = 2; p <= n; p++)
        {
            if (primes[p])
            {
                Console.Write($"{p} ");
                for (int ind = p * 2; ind <= n; ind += p)
                    primes[ind] = false;
            }
        }
    }
}