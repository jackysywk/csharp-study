internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, int> dictA = new Dictionary<string, int>();
        Dictionary<string, int> dictB = new Dictionary<string, int>();
        dictA["a"] = 1;
        dictA["b"] = 3;
        dictA["c"] = 5;

        dictB["a"] = 3;
        dictB["c"] = 6;
        dictB["d"] = 9;
        Dictionary<string, int> dictC = new Dictionary<string, int>(dictB);
        foreach (KeyValuePair<string,int> de in dictA)
        {
            dictC[de.Key] = dictA[de.Key];
        }
        
        foreach (KeyValuePair<string,int> de in dictC)
        {
            Console.WriteLine($"{de.Key} {de.Value}");
        }




    }
}