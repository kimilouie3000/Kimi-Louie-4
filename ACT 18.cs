using System;

class Program
{
    static void Main()
    {
        // Password Validation
        string[] passwords = new string[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter password #{i + 1}: ");
            passwords[i] = Console.ReadLine();

            string pwd = passwords[i];
            bool hasUpper = false, hasDigit = false, hasSpecial = false;

            foreach (char c in pwd)
            {

            }
            if (pwd.Length < 8)
                Console.WriteLine("Invalid");
            else if (hasUpper && hasDigit && hasSpecial)
                Console.WriteLine("Strong");
            else
                Console.WriteLine("Weak");
        }
    }
}

