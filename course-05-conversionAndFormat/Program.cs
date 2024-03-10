internal class Program
{
    private static void Main(string[] args)
    {
        string name;
        int age;
        float weight;
        string input;
        Console.WriteLine("請輪入名字:");
        input = Console.ReadLine();
        name = input;
        Console.WriteLine("請輸入年齡:");
        input = Console.ReadLine();
        age = Convert.ToInt32(input);
        Console.WriteLine("請輸入體重:");
        input = Console.ReadLine();
        float.TryParse(input, out weight);

        Console.WriteLine($"{name}今年{age}歲，體重{weight}為千克。");
        Console.WriteLine("請按任意鍵繼續");
        Console.ReadKey();
        Console.WriteLine("請輸入整數n1:");
        float n1;
        input = Console.ReadLine();
        float.TryParse(input, out n1);
        Console.WriteLine("請輸入整數n2:");
        float n2;
        input = Console.ReadLine();
        float.TryParse(input, out n2);
        Console.WriteLine("請輸入整數n3:");
        float n3;
        input = Console.ReadLine();
        float.TryParse(input, out n3);
        Console.WriteLine($"平均數是{(n1+n2+n3)/3}");

    }
}