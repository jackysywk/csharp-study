internal class Program
{
    static int[,] tickets = new int[4,5];
    private static void Main(string[] args)
    {
        for (int i = 0; i< tickets.GetLength(0); i++)
            {
                for (int j = 0; j< tickets.GetLength(1); j++)
                {
                    tickets[i,j] = 1;
                }

            }
        int row;
        int col;
        while (true)
        {
            PrintTicket();
            Console.WriteLine("請輸入第幾行 1-4");
            row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("請輸入第幾列 1-5");
            col = Convert.ToInt32(Console.ReadLine());
            if (tickets[row-1,col-1]== 1)
            {
                tickets[row-1,col-1] = 0;
                Console.WriteLine("購買成功");
            }
            else
            {                
                Console.WriteLine("購買失敗");

            }


        }

    }
    static void PrintTicket()
    {
        for (int i = 0; i< tickets.GetLength(0); i++)
            {
                for (int j = 0; j< tickets.GetLength(1); j++)
                {
                    int b = tickets[i,j];
                    if (b==1)
                    {
                        Console.Write ($"{i+1}_{j+1} 有票 ");
                    }
                    else
                    {
                        Console.Write ($"{i+1}_{j+1} 沒票 ");
                    }
                }
                Console.WriteLine();
            }
    }
}