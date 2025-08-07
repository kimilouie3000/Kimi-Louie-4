using System;
class Program
{
    static void Main()
    {
        // The program reads 4 passwords from the user and checks one carefully
        string[] passwords = new string[4];

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Enter password #{i + 1}: ");
            passwords[i] = Console.ReadLine();

            bool hasUpper = false;
            foreach (char c in passwords[i])
                if (char.IsUpper(c)) hasUpper = true;

            if (passwords[i].Length >= 6 && hasUpper)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}

