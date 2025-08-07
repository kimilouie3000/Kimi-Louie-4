using System;

class Program
{
    static void Main()
    {
        // The program propmts the user to enter their favourite fruits
        string[] fruits = new string[5];
        int dalandanCount = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter favorite fruit #{i + 1}: ");
            fruits[i] = Console.ReadLine().ToLower();
            if (fruits[i] == "Dalandan")
                dalandanCount++;
        }

        Console.WriteLine($"\nYou entered 'dalandan' {dalandanCount} time(s).");
    }
}
