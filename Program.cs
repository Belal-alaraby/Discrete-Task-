namespace Project_2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("ente the 1st number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("ente the 2nd number");
            int y = int.Parse(Console.ReadLine());


            for (int i = x; i <= y; i++)
            {
                int sum = 0;
                for (int n = 1; n < i; n++)
                {
                    if (i % n == 0)
                        sum = sum + n;
                }
                if (sum == i)

                    Console.WriteLine(i);
            }
        }
    }
}