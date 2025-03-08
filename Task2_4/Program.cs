namespace Task2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());
          
            int m = (l / 1000);
            int dm = (l % 1000 / 100);
            int sm = (l % 1000 % 100 / 10);
            int mm = (l % 1000 % 100 % 10/1);

            Console.WriteLine("{0},{1},{2},{3}", m, mm, sm, dm);
            Console.ReadKey();
        }
    }
}
