using System;

namespace FormulaDll
{
    public class Calculator
    {
        // Формула: вычисление гипотенузы (корень из суммы квадратов)
        // a^2 + b^2 = c^2
        public static double Calculate(double a, double b)
        {
            // Math.Sqrt - квадратный корень
            return Math.Sqrt(a * a + b * b);
        }
    }
}