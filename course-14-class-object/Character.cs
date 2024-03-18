class Character
{
    public string name;
    public int hp;
    public int attack;
    public int def;

    public void PrintCha()
    {
        Console.WriteLine($"{name}'s hp is {hp}, attack is {attack} and defense is {def}");
        return;
    }
}