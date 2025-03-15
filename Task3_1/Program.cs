namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int a = firstNumber - secondNumber;
            if (a > 0)
            {
                Console.WriteLine("{0}>{1}", firstNumber, secondNumber);

            }
            else if (a == 0)
            {
                Console.WriteLine("{0}={1}", firstNumber, secondNumber);
            }
            else if (a < 0)
            {
                Console.WriteLine("{0}<{1}", firstNumber, secondNumber);
            }
            Console.ReadKey();
        }
    }
}
