using System;

class Program
{
    static void Main()
    {
        int[] totals = new int[5];
        string[] names = new string[5];

        for (int i = 0; i < 5; i++)
        {
            // Prompt for student name and grades
            Console.Write($"\nEnter name of student #{i + 1}: ");
            names[i] = Console.ReadLine();
            int total = 0;

            for (int j = 1; j <= 3; j++)
            {
                int grade;
                while (true)
                {
                    Console.Write($"Enter grade {j} (0–100): ");
                    grade = int.Parse(Console.ReadLine());
                    if (grade >= 0 && grade <= 100) break;
                    Console.WriteLine("Invalid grade! Try again.");
                }
                total += grade;
            }

            totals[i] = total;
        }
    }
}

