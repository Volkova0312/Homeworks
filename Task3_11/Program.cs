namespace Task3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());//длина участка
            int b = Convert.ToInt32(Console.ReadLine());//ширина участка
            int p = Convert.ToInt32(Console.ReadLine());//длина 1-го дома
            int q = Convert.ToInt32(Console.ReadLine());//ширина 1-го дома
            int r = Convert.ToInt32(Console.ReadLine());//длина 2-го дома
            int s = Convert.ToInt32(Console.ReadLine());//ширина 2-го дома
            int square = a * b-((a-p)*(b-q))-((a-r)*(b-s));
            if (square < 0)
            {
                Console.WriteLine("Строительство возможно");
            }
            else
            {
                Console.WriteLine("Строительство невозможно");
            }


            Console.ReadKey();
        }
    }
}
