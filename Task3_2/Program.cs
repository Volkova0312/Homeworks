namespace Task3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            int max = Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber);
            Console.WriteLine ("Максимальное значение = {0}", max);
            Console.ReadKey();
        }
    }
}
