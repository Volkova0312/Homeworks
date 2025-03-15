namespace Task3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int a = number % 2;
            if (a == 0)
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет");
            }
            Console.ReadKey();
        }
    }
}
