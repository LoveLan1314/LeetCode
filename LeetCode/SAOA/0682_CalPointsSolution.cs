using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class CalPointsSolutionSolution
    {
        public int CalPoints(string[] ops)
        {
            var stack = new Stack<int>();
            for (int i = 0; i < ops.Length; i++)
            {
                var value = ops[i];
                if (value == "+")
                {
                    var preValue = stack.Pop();
                    var preValue2 = stack.Peek();
                    stack.Push(preValue);
                    stack.Push(preValue + preValue2);
                }
                else if (value == "C")
                {
                    stack.Pop();
                }
                else if (value == "D")
                {
                    var preValue = stack.Peek();
                    stack.Push(preValue * 2);
                }
                else
                {
                    stack.Push(int.Parse(value));
                }
            }
            return stack.Sum();
        }
    }
}
