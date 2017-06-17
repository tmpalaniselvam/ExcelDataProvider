using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// Represents different functions required for Calculator.
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// Add operation for the given numbers
        /// </summary>
        /// <value>addition of both numbers</value>
        int Add(int num1, int num2);

        /// <summary>
        /// Multiply operation for the given numbers
        /// </summary>
        /// <value>Multiplication of both numbers</value>
        int Multiply(int num1, int num2);

        /// <summary>
        /// Subtract operation for the given numbers
        /// </summary>
        /// <value>Subtraction result</value>
        int Subtract(int num1, int num2);
    }
}
