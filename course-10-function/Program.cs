using System.Globalization;

internal class Program
{
    static int RandNum()
    {
        Random random = new Random();
        int digits = random.Next(1,100);
        return digits;
    }

    static int InputNum()
    {
        Console.WriteLine("Guess a number");
        int answer = Convert.ToInt32(Console.ReadLine());
        return answer;
    }
    private static void Main(string[] args)
    {

        int digits = RandNum();
        //Console.WriteLine(digits);

        int guessCount = 1;
        
        int answer = InputNum();

        while (answer != digits)
        {
            if (answer > digits)
            {
                Console.WriteLine("Too Large");
            }
            else if (answer < digits)
            {
                Console.WriteLine("Too small");
            } 
            Console.WriteLine("Let's guess again!");
            answer = Convert.ToInt32(Console.ReadLine());
            guessCount++;
        }
        
        Console.WriteLine($"You are correct.  The answer is {digits}");
        Console.WriteLine($"You guessed for {guessCount} times!");
    }
}