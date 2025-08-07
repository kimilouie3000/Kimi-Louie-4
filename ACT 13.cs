using System;
class Program
{
    static void Main()
    {
        // This program collects email address from teh user.
        string[] emails = new string[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter email #{i + 1}: ");
            emails[i] = Console.ReadLine();
            {
                string username = emails[i].Split('@')[0];
                Console.WriteLine($"Valid - Username: {username}");
            }
            {
                Console.WriteLine("Invalid email!");
            }
        }
    }
}
