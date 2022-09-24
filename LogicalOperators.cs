using System;

namespace sess03_StatementsAndOperators
{
    public class LogicalOperators
    {
        static void Main(string[] args)
        {
            bool firstCondition = false, secondCondition = true;
            bool item_A = true;

            //Illustrate the various logical operators
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine($"!{firstCondition} results in {(firstCondition)}");
            Console.WriteLine($"!{secondCondition} results in {(!secondCondition)}");
            Console.WriteLine($"{firstCondition} & {secondCondition} results in {(firstCondition & secondCondition)}");
            Console.WriteLine($"{secondCondition} & {item_A} results in {(secondCondition) & item_A}");
            Console.WriteLine($"{firstCondition} | {secondCondition} results in {(firstCondition | secondCondition)}");
            Console.WriteLine($"{secondCondition} | {item_A} results in {(secondCondition | item_A)}");
            Console.WriteLine("\n--------------------------------------------------------------------\n");

            Console.WriteLine("Illustrating the various C# logical operators");
            Console.WriteLine("________________________________________");
            Console.WriteLine($"!{firstCondition} results in {!(firstCondition)}");
            Console.WriteLine($"!{secondCondition} results in {!(secondCondition)}");
            Console.WriteLine($"{item_A} && {secondCondition} results in " + $"({item_A && secondCondition})");
            Console.WriteLine($"{firstCondition} && {secondCondition} results in " + $"({firstCondition && secondCondition})");
            Console.WriteLine($"{item_A} && {firstCondition} results in " + $"({item_A && firstCondition})");
            Console.WriteLine($"{firstCondition} && {firstCondition} results in " + $"({firstCondition && firstCondition})");
            Console.WriteLine($"{item_A} || {secondCondition} results in " + $"({item_A || secondCondition})");
            Console.WriteLine($"{firstCondition} || {secondCondition} results in " + $"({firstCondition || secondCondition})");
            Console.WriteLine($"{item_A} || {firstCondition} results in " + $"({item_A || firstCondition})");
            Console.WriteLine($"{firstCondition} || {firstCondition} results in " + $"({firstCondition || firstCondition})");
            Console.WriteLine("________________________________________");
        }
    }
}