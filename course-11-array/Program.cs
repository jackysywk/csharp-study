internal class Program
{
    static void task1(){
        string[] nameArray = new string[5];
        for (int i = 0;i<5;i++)
        {
            Console.WriteLine($"請輸入第{i+1}個名字：");
            nameArray[i] = Console.ReadLine();
        }
        Console.WriteLine(String.Join('\n',nameArray));
    }
    static int Sum(int[] array)
    {
        int result=0;
        foreach (int number in array)
        {
            result += number;
        }

        return result;
    }

    static int MinElement(int[] array)
    {
        int element=array.ToList().IndexOf(array.Min());
        return element;
    }

    static double Average(int[] array)
    {
        double average;
        average = array.Sum()/array.Length;
        return average;
    }
    private static void Main(string[] args)
    {
        task1();

        
        int[] array = {1,2,3,4,5};
        int result = Sum(array);
        Console.WriteLine(result);

        int[] minArray = {9,8,7,6,5,4};
        int element = MinElement(minArray);
        Console.WriteLine(element);

        double average = Average(minArray);
        Console.WriteLine(average);
    }
}