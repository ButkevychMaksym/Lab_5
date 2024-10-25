using System;

namespace WpfApp1.Models
{
    /// <summary>
    /// Model for basic arithmetic operations.
    /// </summary>
    public class CalculatorModel
    {
        /// <summary>
        /// Adds two numbers.
        /// </summary>
        /// <param name="num1">First number.</param>
        /// <param name="num2">Second number.</param>
        /// <returns>Sum of num1 and num2.</returns>
        public double Add(double num1, double num2) => num1 + num2;

        /// <summary>
        /// Subtracts the second number from the first.
        /// </summary>
        /// <param name="num1">First number.</param>
        /// <param name="num2">Number to subtract.</param>
        /// <returns>Difference of num1 and num2.</returns>
        public double Subtract(double num1, double num2) => num1 - num2;

        /// <summary>
        /// Multiplies two numbers.
        /// </summary>
        /// <param name="num1">First number.</param>
        /// <param name="num2">Second number.</param>
        /// <returns>Product of num1 and num2.</returns>
        public double Multiply(double num1, double num2) => num1 * num2;

        /// <summary>
        /// Divides the first number by the second.
        /// </summary>
        /// <param name="num1">Numerator.</param>
        /// <param name="num2">Denominator.</param>
        /// <returns>Quotient of num1 divided by num2.</returns>
        /// <exception cref="DivideByZeroException">Thrown if num2 is zero.</exception>
        public double Divide(double num1, double num2)
        {
            if (num2 == 0) throw new DivideByZeroException("Cannot divide by zero.");
            return num1 / num2;
        }
    }
}
