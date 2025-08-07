using System;

class Program
{
    static void Main()
    {
        // Sales data for each month
        string[] months = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", 
                           "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
        float[] sales = new float[12];
        float total = 0;
        int maxIndex = 0, minIndex = 0;

        for (int i = 0; i < 12; i++)
        {
            Console.Write("Enter sales for {months[i]}: ");
            sales[i] = float.Parse(Console.ReadLine());
            total += sales[i];

            if (sales[i] > sales[maxIndex]) maxIndex = i;
            if (sales[i] < sales[minIndex]) minIndex = i;
        }

        float average = total / 12;

        Console.WriteLine("\nHighest: {months[maxIndex]} - {sales[maxIndex]}");
        Console.WriteLine("Lowest: {months[minIndex]} - {sales[minIndex]}");
        Console.WriteLine("Average Sales: {average:F2}");
    }
}

