using System;

class Program
{
    static void Main()
    {
        // This program calculates the total budget and identifies the category.
        string[] categories = { "Food", "Rent", "Utilities", "Transport", "Others" };
        int[] expenses = new int[5];
        int income = 25000, total = 0, maxIndex = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter budget for {categories[i]}: ");
            expenses[i] = int.Parse(Console.ReadLine());
            total += expenses[i];
            if (expenses[i] > expenses[maxIndex]) maxIndex = i;
        }

        Console.WriteLine("\nTotal Budget: {total}");
    }
}

