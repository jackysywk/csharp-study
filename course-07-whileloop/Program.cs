using System.Formats.Asn1;

internal class Program
{
    private static void Main(string[] args)
    {
        int result = 0;
        int i = 1;
        while (i <=100)
        {
            result +=i;
            i++;
        }
        Console.WriteLine($"i equals to {result}");


        Random random = new Random();
        int digits = random.Next(1,100);
        //Console.WriteLine(digits);
        int answer;
        int guessCount = 1;
        Console.WriteLine("Guess a number");
        answer = Convert.ToInt32(Console.ReadLine());
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