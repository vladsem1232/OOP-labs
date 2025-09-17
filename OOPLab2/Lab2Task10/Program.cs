using System;

class Task10
{
    static void Main()
    {
        Console.WriteLine("Enter numbers:");
        string[] input = Console.ReadLine().Split();
        int[] numbers = new int[input.Length];
        
        for (int i = 0; i < input.Length; i++)
            numbers[i] = int.Parse(input[i]);
        Console.WriteLine("Enter difference:");
        int difference = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i+1; j < numbers.Length; j++)
            {
                if (Math.Abs(numbers[i] - numbers[j]) == difference)
                    count++;
            }
        }
        Console.WriteLine($"Кількість пар елементів із різницею {difference}: {count}");
    }
}