using System;

class Task6
{
    static void Main()
    {
        Console.WriteLine("Enter elements:");
        string input = Console.ReadLine();
        
        string[] elements = input.Split(' ');
        int[] arr = new int[elements.Length];
        
        for (int i = 0; i < arr.Length;i++)
            arr[i] = int.Parse(elements[i]);

        int start = 0;
        int len = 1;

        int beststart=0;
        int bestlen=1;

        for (int pos = 1; pos < elements.Length; pos++)
        {
            if (arr[pos] == arr[pos - 1])
                len++;
            else
            {
                start = pos;
                len = 1;
            }

            if (len > bestlen)
            {
                bestlen = len;
                beststart = start;
            }
        }

        for (int i = beststart; i < beststart + bestlen; i++)
        {
            Console.Write($"{arr[i]} ");
        }
    }
}