using System;
class Program
{
    static void Main()
    {
        string[] words = new string[5];

        for (int i = 0; i < 5; i++)
        {
            // The user is prompted to enter a word
            Console.Write($"Enter word #{i + 1}: ");
            words[i] = Console.ReadLine();

            string reversed = "";
            for (int j = words[i].Length - 1; j >= 0; j--)
                reversed += words[i][j];

            if (words[i].Equals(reversed, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not a Palindrome");
        }
    }
}
