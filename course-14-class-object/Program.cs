using System.Runtime.CompilerServices;

internal class Program
{
    static bool round(Character atk_char, Character def_char)
    {
        Console.WriteLine($"{atk_char.name} attacked {def_char.name}");
            def_char.hp -= atk_char.attack - def_char.def;
            if (def_char.hp <= 0)
            {
                Console.WriteLine($"{def_char.name} is dead");
                return true;
            }
            else
            {  
                Console.WriteLine($"{def_char.name} has {def_char.hp}hp remained");
                return false;
            }
        
    }
    private static void Main(string[] args)
    {
        Character char1 = new Character();
        char1.name = "pikachiu";
        char1.hp = 100;
        char1.attack=20;
        char1.def = 5;

        Character char2 = new Character();
        char2.name = "Turtle";
        char2.hp = 50;
        char2.attack=20;
        char2.def = 10;

        bool gameEnd = false;
        while (true)
        {
            gameEnd = round(char1, char2);
            if (gameEnd)
            {
                break;
            }
            gameEnd = round(char2, char1);
            if (gameEnd)
            {
                break;
            }

        }
    }
}

