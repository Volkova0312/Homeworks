namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());
            int m = (l % 1000 % 100 % 10 / 1);
            switch (m)
            {
                case 1:
                    Console.WriteLine("Мы построили {0} дом", l);
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Мы построили {0} домa", l);
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 0:
                    Console.WriteLine("Мы построили {0} домов", l);
                    break;
            }

            Console.ReadKey();
        }
    }
}
