using IRIS_Test.Helpers;
using IRIS_Test.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRIS_Test.Services
{
    internal class BracketChecker : IBracketChecker
    {
        public string CheckBalancedBrackets(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                return "Not Balanced";

            Stack<char> stack = new Stack<char>();

            foreach (var ch in expression)
            {
                if (BracketUtils.IsOpeningBracket(ch))
                {
                    stack.Push(ch);
                }
                else if (BracketUtils.IsClosingBracket(ch))
                {
                    if (stack.Count == 0 || !BracketUtils.IsMatchingPair(stack.Pop(), ch))
                    {
                        return "Not Balanced";
                    }
                }
            }

            return stack.Count == 0 ? "Balanced" : "Not Balanced";
        }
    }
}
