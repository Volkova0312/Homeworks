namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());
            int lInMm = ((l * 254) / 10);
            int m = (lInMm / 1000);
            int sm = (lInMm % 1000 / 10);
            int mm = (lInMm % 1000 % 100 / 10);
            
            Console.WriteLine(lInMm);
            Console.WriteLine("m={0},sm={1}, mm={2}", m, sm, mm);
            Console.ReadKey();
        }
    }
}
