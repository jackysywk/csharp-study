using System.Formats.Asn1;

internal class Program
{
    private static void Main(string[] args)
    {
        // Set up the Random
        Random random = new Random();
        int digits = random.Next(1, 100);

        int answer = -1;
        int guessCount = 0;
        while (answer != digits)
        {
            if (guessCount == 0)
            { }
            else if (answer > digits)
            {
                Console.WriteLine("Too Large");
            }
            else if (answer < digits)
            {
                Console.WriteLine("Too small");
            }
            if (guessCount == 0)
            {
                Console.WriteLine("Let's guess a number!");
            }
            else
            {
                Console.WriteLine("Let's guess again!");
            }
            while (true)
            {
                string? input = Console.ReadLine();
                if (input != null)
                {
                    if (int.TryParse(input, out answer))
                    {
                        guessCount++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("It is not a valid input.  Input an integer!");
                    }

                }
            }


        }
        Console.WriteLine($"You are correct.  The answer is {digits}");
        Console.WriteLine($"You guessed for {guessCount} times!");
    }
}