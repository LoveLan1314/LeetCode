using System.Collections.Generic;

namespace LeetCode.SAOA.One
{
    internal sealed class EvalRPNSolution
    {
        private static readonly string[] _operationKeys = new string[] { "+", "-", "*", "/" };
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < tokens.Length; i++)
            {
                var value = tokens[i];
                switch (value)
                {
                    case "+":
                        {
                            int value2 = stack.Pop();
                            int value1 = stack.Pop();
                            stack.Push(value1 + value2);
                        }
                        break;
                    case "-":
                        {
                            int value2 = stack.Pop();
                            int value1 = stack.Pop();
                            stack.Push(value1 - value2);
                        }
                        break;
                    case "*":
                        {
                            int value2 = stack.Pop();
                            int value1 = stack.Pop();
                            stack.Push(value1 * value2);
                        }
                        break;
                    case "/":
                        {
                            int value2 = stack.Pop();
                            int value1 = stack.Pop();
                            stack.Push(value1 / value2);
                        }
                        break;
                    default:
                        stack.Push(int.Parse(value));
                        break;
                }
            }
            return stack.Pop();
        }
    }
}
