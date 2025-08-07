using System;

class Program
{
    static void Main()
    {
        // The program collects ages of 5 customers.
        int[] ages = new int[5];
        int teenCount = 0;

        for (int i = 0; i < 5; i++)
        {
            while (true)

            {
                Console.Write("Enter age of customer {i + 1}: ");
                int age = int.Parse(Console.ReadLine());

                if (age >= 10 && age <= 99)
                {
                    ages[i] = age;
                    if (age >= 13 && age <= 19) teenCount++;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid age! Please enter 10–99.");
                }
            }
        }

        Console.WriteLine("\nValid Ages: " + string.Join(", ", ages));
        Console.WriteLine("Number of Teenagers: " + teenCount);
    }
}
