using HackerRank.Business.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Business.Services
{
    public class BalancedBrackets : IBalancedBrackets
    {
        public string AreBalanced(string brackets)
        {
            var expression = brackets.Select(it => it).ToList();
            var stack = new Stack<char>();

            foreach (var item in expression)
                switch (item)
                {
                    case '{':
                    case '(':
                    case '[':
                        stack.Push(item);
                        break;
                    case '}':
                    case ')':
                    case ']':
                        {
                            if (stack.Count == 0)
                            {
                                return "NO";
                            }

                            if (!IsMatchingPair(stack.Pop(), item))
                                return "NO";

                            break;
                        }
                }

            return stack.Count == 0 ? "YES" : "NO";
        }

        private static bool IsMatchingPair(char left, char right) =>
            left == '(' && right == ')' || (left == '{' && right == '}') || (left == '[' && right == ']');
    }
}