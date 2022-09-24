using System;

namespace sess03_StatementsAndOperators
{
    /// <summary>
    /// C# program demonstrating uncheked overflow
    /// </summary>
    public class UncheckOverFlow
    {
        static void Main(string[] args)
        {
            byte numOne = 255, numTwo = 1, result = 0;
            try
            {
                unchecked
                {
                    result = (byte)(numOne + numTwo);
                }
                Console.WriteLine("Result: " + result);
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
        }
    }
}