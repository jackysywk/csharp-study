internal class Program
{

    private static void Main(string[] args)
    {
        Random random = new Random();
        Dictionary<string,int> dictA = new Dictionary<string, int>();
        dictA.Add("a",random.Next(1,11));
        dictA.Add("b",random.Next(1,11));
        dictA.Add("c",random.Next(1,11));
        dictA.Add("d",random.Next(1,11));
        dictA.Add("e",random.Next(1,11));
        dictA.Add("f",random.Next(1,11));

        // Printing the dictionary and removing the even number key-value pair
        foreach (KeyValuePair<string,int> de in dictA)
        {
            Console.WriteLine($"{de.Key} {de.Value}");
            if (de.Value % 2 == 0)
            {
                dictA.Remove(de.Key);
            }
        }

        // Printing the dictionary
        foreach (KeyValuePair<string,int> de in dictA)
        {
            Console.WriteLine($"{de.Key} {de.Value}");
        }
    }
}