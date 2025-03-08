namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal l = Convert.ToDecimal(Console.ReadLine());
            decimal a = Math.Round(l, MidpointRounding.ToPositiveInfinity);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
