using System;

class Task3
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Enter {n} numbers:");
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] =  int.Parse(Console.ReadLine());
        }

        int k = n / 4;
        int[] first = new int[2 * k];
        int[] second = new int[2 * k];

        for (int i = 0; i < k; i++)
            first[i] = arr[k - 1 - i];
        
        for (int i = 0; i < k; i++)
            first[k+i] = arr[n - 1 - i];

        for (int i = 0; i < 2*k; i++)
            second[i] = arr[k + i];

        int[] sum = new int[2 * k];
        for (int i = 0; i < 2 * k; i++)
            sum[i] = first[i] + second[i];

        for (int i = 0; i < 2*k; i++)
        {
            Console.Write($"{sum[i]} ");
        }
    }
}