namespace Task3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int a = Math.Abs(number);
            if ( a >= 10)
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
