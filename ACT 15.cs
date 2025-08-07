using System;

class Program
{
    static void Main()
    {
        //LUCKY NUMBER GAME
        int[] entries = new int[20];
        int[] winners = {7, 21, 42, 55, 88};

        for (int i = 0; i < 20; i++)
        {
            int num;
            while (true)
            {
                Console.Write("User #{i + 1}, enter your lucky number (1–99): ");
                num = int.Parse(Console.ReadLine());
                if (num >= 1 && num <= 99) break;
                Console.WriteLine("Invalid! Please enter a number between 1 and 99.");
            }

            entries[i] = num;

            foreach (int win in winners)
            {
                if (num == win)
                {
                    Console.WriteLine(" Congratulations IDIOT! You picked a winning number!");
                    break;
                }
            }
        }
    }
}

