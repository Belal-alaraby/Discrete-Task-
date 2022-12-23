namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Entre the First limit ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Entre the Last limit ");
            int n2 = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = n1; i <= n2; i++)
            {
               for (int x = 1; x <= n2; x++)
                {
                    if (i % x == 0)

                        sum++;
                }

               if (sum == 2)
                {
                    Console.WriteLine(i);
                    sum = 0;
                }
               else
                {
                    sum = 0;
                }
                    
               
            }
        }
    }
}