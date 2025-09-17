using System;

class Task1
{
    static void Main()
    {   
        Console.WriteLine("Enter first line: ");
        string firstline = Console.ReadLine();
        
        Console.WriteLine("Enter second line: ");
        string secondline = Console.ReadLine();
        
        string[] words = firstline.Split(' ');
        string[] words2 = secondline.Split(' ');
        int left = 0;
        int right = 0;
        Console.WriteLine("Enter n: ");
        int n =  int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if (words[i] == words2[i]) left++;
        }
        
        int minlength = Math.Min(words.Length, words2.Length);
        int ind1 = words.Length-1;
        int ind2 = words2.Length-1;
        while (ind1 >= minlength - n && ind2 >= minlength - n)
        {
            if (words[ind1] == words2[ind2])
            {
                right++;
            }
            ind1--;
            ind2--;
        }
        

        if (left > right)
        {
            Console.WriteLine("Найбільший спільний кінець є ліворуч: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(words[i] + " ");
            }
        }
        else if (left < right)
        {
            Console.WriteLine("Найбільший спільний кінець є праворуч:");
            for (int i = words.Length - n; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
        }
        else
        {
            Console.WriteLine("Немає спільних слів зліва і справа");
        }
    }
}

