using System;

class Program
{
    static void Main()
    {
        // This purpose of the code is to simulate a simple patient symptom checker
        string[] symptoms = new string[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter symptom for patient #{i + 1}: ");
            symptoms[i] = Console.ReadLine().ToLower();

            if (symptoms[i].Contains("fever") || symptoms[i].Contains("cough"))
                Console.WriteLine("Assigned to: General Medicine\n");
            else if (symptoms[i].Contains("injury") || symptoms[i].Contains("burn"))
                Console.WriteLine("Assigned to: Emergency\n");
            else
                Console.WriteLine("Assigned to: Specialist\n");
        }
    }
}

