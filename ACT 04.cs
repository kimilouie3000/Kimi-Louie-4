using System;

class Program
{
    static void Main()
    {
        // The program prompts the user to enter three names.
        string[] names = new string[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter name #{i + 1}: ");
            names[i] = Console.ReadLine();

            char first = names[i][0];
            char last = names[i][names[i].Length - 1];

            Console.WriteLine("Original: {names[i]}");
            Console.WriteLine("First: {first}, Upper: {char.ToUpper(first)}");
            Console.WriteLine("Last: {last}, Upper: {char.ToUpper(last)}\n");
        }
    }
}

