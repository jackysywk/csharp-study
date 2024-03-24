using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
class Character
    {
        public static int counter = 0;
        public string name{get; private set;}
        public int attack{get; private set;}
        public int def{get; private set;}
        private int hp; // Backing field
        public int Hp{
            get{ return hp;}
            set
            {
                if (value >=0)
                {
                    hp = value;
                }
                else
                {
                    hp = 0;
                }

            }
        }

        // create method
        public Character()
        {
            name = "unknown";
            counter++;
        }

        // create method with four arguments
        public Character(string name, int hp, int attack, int def)
        {
            this.name = name;
            this.hp = hp;
            this.attack = attack;
            this.def = def;
            counter++;

        }

        // create method with 2 arguments only
        public Character(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
            this.attack = 1;
            this.def = 0;
            counter++;
        }
        public void Attack(Character other)
        {
            Console.WriteLine($"{this.name} attack!");
            int damage = this.attack - other.def;
            other.Hp -= damage;
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
        public void PrintCha()
        {
            Console.WriteLine($"------{name}------");
            Console.WriteLine($"hp:{hp} attack:{attack} def:{def}");
        }

    }
    

internal class Program
{
    


    static void Main(string[] args)
    {
        Character c1 = new Character("Tommy", 100, 15, 1);
        Character c2 = new Character("Jerry", 90);
        Character c3 = CreateCha("Seed");
        Console.WriteLine(Character.counter);
        Battle(c1, c3);

        
    }
    static void Battle(Character c1, Character c2)
    {
        Character victory;
        while (true)
        {

            c1.Attack(c2);


            if (c2.IsDead())
            {
                victory = c1;
                break;
            }

            c2.PrintCha();
            c2.Attack(c1);
            c1.PrintCha();
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