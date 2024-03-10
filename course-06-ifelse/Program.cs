internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Type any interger:");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input % 2 == 0)
        {
            Console.WriteLine(input * 2);
        }
        else if (input % 3 == 0)
        {
            Console.WriteLine(input * 2);
        }
        else if (input % 5== 0)
        {
            Console.WriteLine(input * 2);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}