using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRIS_Test.Helpers
{
    internal class BracketUtils
    {
        public static bool IsOpeningBracket(char ch)
        {
            return ch == '(' || ch == '{' || ch == '[';
        }

        public static bool IsClosingBracket(char ch)
        {
            return ch == ')' || ch == '}' || ch == ']';
        }

        public static bool IsMatchingPair(char opening, char closing)
        {
            return (opening == '(' && closing == ')') ||
                   (opening == '{' && closing == '}') ||
                   (opening == '[' && closing == ']');
        }
    }
}
