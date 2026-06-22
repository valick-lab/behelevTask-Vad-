using CalculatorLib;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("=== CalculatorLib Demo ===");

            Console.WriteLine($"10 + 5 = {calculator.Add(10, 5)}");
            Console.WriteLine($"10 - 5 = {calculator.Subtract(10, 5)}");
            Console.WriteLine($"10 * 5 = {calculator.Multiply(10, 5)}");
            Console.WriteLine($"10 / 5 = {calculator.Divide(10, 5)}");

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}