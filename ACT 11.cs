using System;

class Program
{
    static void Main()
    {
        string[] names = new string[10];
        int[] ages = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter name #{i + 1}: ");
            names[i] = Console.ReadLine();

            int age;
            while (true)
            {
                Console.Write("Enter age: ");
                age = int.Parse(Console.ReadLine());
                if (age >= 0 && age <= 120) break;
                Console.WriteLine("Invalid age! Try again.");
            }
            ages[i] = age;
        }

        Console.WriteLine("\nVoter List:");
        for (int i = 0; i < 10; i++)
        {
            string category = "Not eligible";

            if (ages[i] >= 18)
            {
                if (ages[i] <= 30) category = "Young Voter";
                else if (ages[i] <= 60) category = "Mid-age Voter";
                else category = "Senior Voter";
            }

            Console.WriteLine($"{names[i]} - Age: {ages[i]}, Category: {category}");
        }
    }
}

