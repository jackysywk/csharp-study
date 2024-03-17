using System.Globalization;

internal class Program
{
    static Random random = new Random();
    static int RandNum()
    {
        int digits = random.Next(1,99);
        return digits;
    }

    static int InputNum()
    {
        Console.WriteLine("Guess a number");
        int answer = Convert.ToInt32(Console.ReadLine());
        return answer;
    }
    static int count = 0;
    private static void Main(string[] args)
    {

        int digits = RandNum();
        //Console.WriteLine(digits);

        
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
            count++;
        }
        
        Console.WriteLine($"You are correct.  The answer is {digits}");
        Console.WriteLine($"You guessed for {count} times!");
    }
}