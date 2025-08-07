using System;
class Program
{
    static void Main()
    {
        int[] numbers = new int[8];

        for (int i = 0; i < 8; i++)
        {
            // Taking input 
            Console.Write($"Enter whole number #{i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());

            // Prime check
            bool isPrime = numbers[i] > 1;
            for (int j = 2; j < numbers[i]; j++)
                if (numbers[i] % j == 0) { isPrime = false; break; }

            // Binary conversion
            string binary = Convert.ToString(numbers[i], 2);

            // Even/odd check
            string parity = (numbers[i] % 2 == 0) ? "Even" : "Odd";

            Console.WriteLine($"Number: {numbers[i]}, Prime: {isPrime}, Binary: {binary}, {parity}\n");
        }
    }
}
