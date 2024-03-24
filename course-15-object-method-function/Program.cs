using System.Numerics;
using System.Runtime.Intrinsics.Arm;

internal class Program
{
    class Character
    {
        public string name;
        public int attack;
        public int def;
        public int hp;

        // create method
        public Character()
        {
            name = "unknown";
        }

        // create method with four arguments
        public Character(string name, int hp, int attack, int def)
        {
            this.name = name;
            this.hp = hp;
            this.attack = attack;
            this.def = def;

        }

        // create method with 2 arguments only
        public Character(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
            this.attack = 1;
            this.def = 0;
        }
        public void Attack(Character other)
        {
            Console.WriteLine($"{this.name} attack!");
            int damage = this.attack - other.def;
            other.hp -= damage;
            Console.WriteLine($"{this.name} made {damage} damage to {other.name}");
        }

        public bool IsDead()
        {
            if (this.hp <=0)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

    }
    static void PrintCha(Character c)
    {
        Console.WriteLine($"------{c.name}------");
        Console.WriteLine($"hp:{c.hp} attack:{c.attack} def:{c.def}");
    }

    

    static void Main(string[] args)
    {
        Character c1 = new Character("Tommy", 100, 15, 1);
        //Character c2 = new Character("Jerry", 90);
        Character c3 = CreateCha("Seed");
        Battle(c1, c3);

        
    }
    static void Battle(Character c1, Character c2)
    {
        Character victory;
        while (true)
        {
            
            c1.Attack(c2);

            PrintCha(c2);
            if (c2.IsDead())
            {
                victory = c1;
                break;
            }
            c2.Attack(c1);
            if (c1.IsDead())
            {
                victory = c2;
                break;
            }
        }
        Console.WriteLine($"the winner is {victory.name}");
    }
    static Random random = new Random();
    static Character CreateCha(string name)
    {
        int hp = random.Next(50,100);
        int attack = random.Next(10,40);
        int def = random.Next(0,10);
        Character c = new Character(name,hp,attack, def);
        return c;
    }

}