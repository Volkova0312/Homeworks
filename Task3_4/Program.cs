namespace Task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            int max = Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber);
            int min = Math.Min(Math.Min(firstNumber, secondNumber), thirdNumber);
            int average = firstNumber + secondNumber + thirdNumber - max - min;
            Console.WriteLine("Среднее значение = {0}", average);
            Console.ReadKey();
        }
    }
}
