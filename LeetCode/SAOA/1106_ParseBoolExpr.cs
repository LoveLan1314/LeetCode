﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SAOA
{
    internal sealed class ParseBoolExprSolution
    {
        public bool ParseBoolExpr(string expression)
        {
            var stack = new Stack<char>();
            int n = expression.Length;
            for (int i = 0; i < n; i++)
            {
                char c = expression[i];
                if (c == ',')
                {
                    continue;
                }
                else if (c != ')')
                {
                    stack.Push(c);
                }
                else
                {
                    int t = 0, f = 0;
                    while (stack.Peek() != '(')
                    {
                        char val = stack.Pop();
                        if (val == 't')
                        {
                            t++;
                        }
                        else
                        {
                            f++;
                        }
                    }
                    stack.Pop();
                    char op = stack.Pop();
                    switch (op)
                    {
                        case '!':
                            stack.Push(f == 1 ? 't' : 'f');
                            break;
                        case '&':
                            stack.Push(f == 0 ? 't' : 'f');
                            break;
                        case '|':
                            stack.Push(t > 0 ? 't' : 'f');
                            break;
                        default:
                            break;
                    }
                }
            }
            return stack.Pop() == 't';
        }
    }
}
