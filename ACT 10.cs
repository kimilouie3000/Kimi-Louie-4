using System;

class Program
{
    static void Main()
    {
        // The program let the user enter six heights and then display the count of short,average and tall people
        int[] heights = new int[6];
        int shortCount = 0, averageCount = 0, tallCount = 0;

        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Enter height #{i + 1} (cm): ");
            heights[i] = int.Parse(Console.ReadLine());

            if (heights[i] < 150) shortCount++;
            else if (heights[i] <= 170) averageCount++;
            else tallCount++;
        }

        Console.WriteLine($"\nShort: {shortCount}");
        Console.WriteLine($"Average: {averageCount}");
        Console.WriteLine($"Tall: {tallCount}");
    }
}

