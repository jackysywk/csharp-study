class Student
{
    public string name;
    public int age;
    public int score;
    
    public Student(string name, int age, int score)
    {
        this.name = name;
        this.age = age;
        this.score = score;
    }

    public void Print()
    {
        Console.WriteLine($"Student:{name} age:{age} score:{score}");
    }

    public Student Copy()
    {
        Student s = new Student(name,age,score);
        return s;
    }
}
internal class Program
{
    static void AddScore(Student student)
    {
        if (student.score<=90)
        {
            student.score+=10;
        }
        else
        {
            student.score = 100;
        }
    }
    static void func(int[] array)
{
    array[0] = 888;
    array = new int[3];
    array[0] = 999;
}

    private static void Main(string[] args)
    {
        Student s1 = new Student("Jacky",31,80);
        Student s2 = new Student("Emma", 30, 95);
        s1.Print();
        s2.Print();
        Student s3 = s2.Copy();
        AddScore(s1);
        AddScore(s2);
        s1.Print();
        s2.Print();

        
        s3.Print();

        int[] array = new int[]{1,2,3};
        func(array);
        Console.WriteLine(array[0]);

    }
}