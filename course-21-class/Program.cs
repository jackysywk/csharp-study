class Address
{
    public string? Flat {get; set;}
    public string? Building {get; set;}

    public string? Town {get; set;}

    public string Info()
    {
        return $"{Town} {Building} {Flat}";
    }
}

class Person
{
    public string? Name {get; set;}
    public Address? Address {get; set;}

    public void PrintInfo()
    {
        Console.WriteLine($"-----{Name}------");
        if (Address != null)
        {
            Console.WriteLine($"Address: {Address.Info()}");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Address address = new Address
        {
            Flat = "23C",
            Building = "MidVale",
            Town = "Tung Chung"
        };

        Person siuming = new Person
        {
            Name = "Siu Ming",
            Address = address
        };

        siuming.PrintInfo();
    }
}