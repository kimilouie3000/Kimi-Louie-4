using System;

class Program
{
    static void Main()
    {
        // The new program propmts the user to enter their grade scores
        float[] scores = new float[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter score #{i + 1}: ");
            scores[i] = float.Parse(Console.ReadLine());

            char grade;

            if (scores[i] >= 90) grade = 'A';
            else if (scores[i] >= 80) grade = 'B';
            else if (scores[i] >= 70) grade = 'C';
            else if (scores[i] >= 60) grade = 'D';
            else grade = 'F';

            Console.Write($"Grade: {grade} - ");

            switch (grade)
            {
                case 'A': Console.WriteLine("Excellent!"); break;
                case 'B': Console.WriteLine("Good job!"); break;
                case 'C': Console.WriteLine("Fair effort."); break;
                case 'D': Console.WriteLine("Needs improvement."); break;
                case 'F': Console.WriteLine("Failing grade."); break;
            }
        }
    }
}
