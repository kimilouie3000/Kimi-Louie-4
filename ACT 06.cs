using System;
class Program
{
    static void Main()
    {
        // The program reads 5 celsius temperatures from the user.
        float[] celsius = new float[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter Celsius #{i + 1}: ");
            celsius[i] = float.Parse(Console.ReadLine());

            float fahrenheit = celsius[i] * 9 / 5 + 32;
            string category;

            if (celsius[i] < 15) category = "Cold";
            else if (celsius[i] <= 30) category = "Warm";
            else category = "Hot";

            Console.WriteLine($"C: {celsius[i]}, F: {fahrenheit}, Category: {category}\n");
        }
    }
}
