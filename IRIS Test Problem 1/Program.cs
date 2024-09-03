using IRIS_Test.Interfaces;
using IRIS_Test.Services;

namespace IRIS_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string expression1 = "[()]{}{[()()]()}";
                string expression2 = "[(])";
                string expression3 = "([]{})";


            IBracketChecker bracketChecker = new BracketChecker();

                Console.WriteLine($"Expression: {expression1} - {bracketChecker.CheckBalancedBrackets(expression1)}");
                Console.WriteLine($"Expression: {expression2} - {bracketChecker.CheckBalancedBrackets(expression2)}");
                Console.WriteLine($"Expression: {expression3} - {bracketChecker.CheckBalancedBrackets(expression3)}");

        }
    }
}
