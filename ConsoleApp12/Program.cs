using System;

class Program
{
    static void Main()
    {
        Func<double, double> discountCalculator = null;

        discountCalculator += price => price * 0.95;  
        discountCalculator += price => price * 0.90;  
        discountCalculator += price => price - 100;   

        double result = discountCalculator(1000);

        Console.WriteLine($"Результат: {result}");
    }
}