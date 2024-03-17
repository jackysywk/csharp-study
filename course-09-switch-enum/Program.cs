using System.Diagnostics;

internal class Program
{
    private enum Fruit
    {
        Apple = 1,
        Banana,
        Orange,
        Grape

    }
    private static void Main(string[] args)
    {
        Console.WriteLine("請輸入1-4， 1蘋果，2香蕉，3桔子，4 葡萄");
        int choice = Convert.ToInt32(Console.ReadLine());
        string fruit = Convert.ToString((Fruit)choice);
        Console.WriteLine($"你選擇了{fruit}");
        
        Console.WriteLine("請輸入購買重量（斤）:");
        int weight = Convert.ToInt32(Console.ReadLine());
        int price = 0;
        switch (fruit)
        {
            case "Apple":
                price = weight * 4;
                break;
            case "Banana":
                price = weight * 6;
                break;
            case "Orange":
                price = weight * 5;
                break;
            case "Grape":
                price = weight * 20;
                break;
            default:
                break;

        }
        Console.WriteLine($"你購買{fruit} {weight}斤，價值{price}");


    }
}