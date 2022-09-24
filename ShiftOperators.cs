using System;

namespace sess03_StatementsAndOperators
{
    /// <summary>
    /// C# program that demonstrates how the left and right shift operators work.
    /// </summary>
    public class ShiftOperators
    {
        static void Main(string[] args)
        {
            uint num = 100;//equal to 1100010000 in binary
            uint result;

            //Diplay the number before the shift operations
            Console.WriteLine($"The variable num hold the value {num} before shift operations.");
            result = num << 1;//Left shift the bits to the left once
            Console.WriteLine($"The number {num} after a single left shift is {result}");
            result = num >> 1;//Right shift the bits to the left once
            Console.WriteLine($"The number {num} after a single right shift is {result}");
        }
    }
}
