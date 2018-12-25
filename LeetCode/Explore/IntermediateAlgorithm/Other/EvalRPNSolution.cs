using System;
using System.Collections.Generic;

namespace LeetCode.Explore.IntermediateAlgorithm.Other
{
    internal class EvalRPNSolution
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < tokens.Length; i++)
            {
                var s = tokens[i];
                if (s == "+" || s == "-" || s == "*" || s == "/")
                {
                    int b = stack.Pop();
                    int a = stack.Pop();
                    int c;
                    switch (s)
                    {
                        case "+":
                            c = a + b;
                            break;
                        case "-":
                            c = a - b;
                            break;
                        case "*":
                            c = a * b;
                            break;
                        case "/":
                            c = a / b;
                            break;
                        default:
                            throw new Exception("操作符错误");
                    }
                    stack.Push(c);
                }
                else
                {
                    stack.Push(int.Parse(s));
                }
            }
            return stack.Pop();
        }
    }
}
