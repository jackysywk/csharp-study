internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("The rocket will be launched!\nPlease press any key to launch!");
        Console.ReadKey();
        for (int i = 10; i>0; i--)
        {
            Console.WriteLine($"{i}");
        }
        Console.WriteLine("The rocket is launched!");
        /*
        Console.WriteLine("3");
        Console.ReadKey();
        */
        Console.WriteLine("準備打沒參數WriteLine");
        Console.WriteLine();
        Console.WriteLine("打了沒參數的WriteLine");

        Console.WriteLine(888);
        Console.WriteLine("888");
    }
}