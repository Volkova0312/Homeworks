namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            int fourthNumber = Convert.ToInt32(Console.ReadLine());
            int max = Math.Max(Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber), fourthNumber);
            Console.WriteLine("Максимальное значение = {0}", max);
            Console.ReadKey();
        }
    }
}
