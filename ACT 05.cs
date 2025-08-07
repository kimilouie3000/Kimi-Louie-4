using System;
class Program
{
    static void Main()
    {
        // The program prompts the user to enter 10 integers.
        int[] numbers = new int[10];
        int even = 0, odd = 0, divisibleBy5 = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter number #{i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());

            if (numbers[i] % 2 == 0) even++;
            else odd++;

            if (numbers[i] % 5 == 0) divisibleBy5++;
        }

        Console.WriteLine($"\nEven: {even}");
        Console.WriteLine($"Odd: {odd}");
        Console.WriteLine($"Divisible by 5: {divisibleBy5}");
    }
}
