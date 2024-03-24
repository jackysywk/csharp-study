public class MyClass
{
    public static int MyStaticField;

    public static void MyStaticMethod()
    {
        MyStaticField++;
        Console.WriteLine($"Static field is {MyStaticField}");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        MyClass.MyStaticField = 10;
        MyClass.MyStaticMethod();
        MyClass.MyStaticMethod();
        MyClass.MyStaticMethod();
        Console.WriteLine(MyClass.MyStaticField);
        

    }
}