namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int g = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());

            double ugolInRadian = (g + m * 60 + s * 360) * (Math.PI / 180);


            Console.WriteLine(ugolInRadian);
            Console.ReadKey();



        }
    }
}
