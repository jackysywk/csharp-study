internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please input any number");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        double product = 1;
        for (int i = 1; i<=number;i++)
        {
            sum+=i;
            product *=i;
        }
        Console.WriteLine($"The sum between 1 and {number} is {sum}");
        Console.WriteLine($"The product between 1 and {number} is {product}");

        PrintFactor(7);
        PrintFactor(11);
        PrintFactor(13);
        for (int j=1;j<=9;j++)
        {
            for (int k=1; k <=9 ; k++)
            {
                Console.Write($"{j} x {k} = {j*k}\t");
            }
            Console.WriteLine();
        }
    }

    public static void PrintFactor(int factor)
    {
        int multiply=0;
        for (int i = 1; multiply < 1000; i++)
        {
            multiply = factor * i;
            Console.WriteLine(multiply);
        }
    }
}