using System;
class Program
{
    static void Main()
    {
        // The program reads 10 votes for candiadates A,B and C.
        string[] votes = new string[10];
        int a = 0, b = 0, c = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Vote #{i + 1} (A, B, or C): ");
            string vote = Console.ReadLine().ToUpper();

            if (vote == "A") a++;
            else if (vote == "B") b++;
            else if (vote == "C") c++;
        }

        Console.WriteLine($"\nVotes - A: {a}, B: {b}, C: {c}");

        if (a > b && a > c) Console.WriteLine("Winner: A");
        else if (b > a && b > c) Console.WriteLine("Winner: B");
        else if (c > a && c > b) Console.WriteLine("Winner: C");
        else Console.WriteLine("It's a tie!");
    }
}

