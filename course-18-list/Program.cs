internal class Program
{
    public static void PrintList(List<int> myList)
    {
        for (int i = 0; i < myList.Count;i++)
        {
            Console.Write($"{myList[i]} ");
        }
        Console.WriteLine();
    }
    private static void Main(string[] args)
    {
        List<int> myList = new List<int> {1,3,5,7,4,3,1,2,6,4};
        List<int> oddList = new List<int>();
        List<int> evenList = new List<int>();
        PrintList(myList);
        for (int i =0; i<myList.Count; i++)
        {
            myList[i]++;
            if (myList[i] % 2 == 0)
            {
                evenList.Add(myList[i]);
            }
            else
            {
                oddList.Add(myList[i]);
            }

        }
        PrintList(myList);
        PrintList(oddList);
        PrintList(evenList);
        bool Loop = true;
        myList = [9,2,4,5,56,2,141,54,6,23,15,5,8];
        PrintList(myList);
        while (Loop)
        {
            for (int i =0; i<myList.Count; i++)
            {
                if (myList[i] % 2 == 0)
                {
                    myList.RemoveAt(i);
                    break;
                }
                if (i == myList.Count-1)
                {
                    Loop=false;
                }
                
            }
            
        }
        PrintList(myList);
    }
}