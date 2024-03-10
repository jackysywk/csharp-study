internal class Program
{
    private static void Main(string[] args)
    {
        int a = 1;
        int b = 2;
        Console.WriteLine("Before exchange");
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");  
        int temp = a;
        a = b;
        b= temp;
        Console.WriteLine("After exchange");
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");        

        Console.WriteLine("請問你叫什麼名字？ ");
        string name  = Console.ReadLine();
        Console.WriteLine($"你好{name}");
    }


}