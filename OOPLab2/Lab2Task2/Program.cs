using System;

class Task2
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
        Console.WriteLine("Enter k:");
        int k = int.Parse(Console.ReadLine());
        int[] sum = new int[n];
        for (int r = 1; r <= k; r++)
        {
            int[] rotated = new int[n];
            for (int i = 0; i < n; i++)
            {
                int ind = (i + r) % n;
                rotated[ind] = arr[i];
            }
            
            for (int i = 0; i < n; i++)
                sum[i] += rotated[i];
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{sum[i]} ");
        }
    }
}