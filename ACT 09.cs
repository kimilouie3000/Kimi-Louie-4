using System;

class Program
{
    static void Main()
    {
        // The program lets the user enter three n umbers and then dislays the multiplication table for each number from 1 to 10
        int[] numbers = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter number #{i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        foreach (int num in numbers)
        {
            Console.WriteLine($"\nTable for {num}:");
            for (int j = 1; j <= 10; j++)
                Console.WriteLine($"{num} x {j} = {num * j}");
        }
    }
}
