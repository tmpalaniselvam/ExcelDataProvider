using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// Calculator
    /// </summary>
    public class Calculator : ICalculator
    {
        /// <summary>
        /// Addition calculation
        /// </summary>
        /// <param name="num1">First Integer data</param>
        /// <param name="num2">Second Integer data</param>
        /// <returns>Integer Result</returns>
        public int Add(int num1, int num2)
        {
            return (num1 + num2);
        }

        /// <summary>
        /// Multiplication calculation
        /// </summary>
        /// <param name="num1">First Integer data</param>
        /// <param name="num2">Second Integer data</param>
        /// <returns>Integer Result</returns>
        public int Multiply(int num1, int num2)
        {
            return (num1 * num2);
        }

        /// <summary>
        /// Subtraction calculation
        /// </summary>
        /// <param name="num1">First Integer data</param>
        /// <param name="num2">Second Integer data</param>
        /// <returns>Integer Result</returns>
        public int Subtract(int num1, int num2)
        {
            return (num1 - num2);
        }
    }
}
