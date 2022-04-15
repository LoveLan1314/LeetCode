using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class DeserializeSolution
    {
        public NestedInteger Deserialize(string s)
        {
            if (s[0] != '[')
            {
                return new NestedInteger(int.Parse(s));
            }
            Stack<NestedInteger> stack = new Stack<NestedInteger>();
            int num = 0;
            bool negative = false;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '-')
                {
                    negative = true;
                }
                else if (char.IsDigit(c))
                {
                    num = num * 10 + c - '0';
                }
                else if (c == '[')
                {
                    stack.Push(new NestedInteger());
                }
                else if (c == ',' || c == ']')
                {
                    if (char.IsDigit(s[i - 1]))
                    {
                        if (negative)
                        {
                            num *= -1;
                        }
                        stack.Peek().Add(new NestedInteger(num));
                    }
                    num = 0;
                    negative = false;
                    if (c == ']' && stack.Count > 1)
                    {
                        NestedInteger ni = stack.Pop();
                        stack.Peek().Add(ni);
                    }
                }
            }
            return stack.Pop();
        }

        public class NestedInteger
        {

            // Constructor initializes an empty nested list.
            public NestedInteger()
            {

            }

            // Constructor initializes a single integer.
            public NestedInteger(int value)
            {

            }

            // @return true if this NestedInteger holds a single integer, rather than a nested list.
            bool IsInteger()
            {
                throw new NotImplementedException();
            }

            // @return the single integer that this NestedInteger holds, if it holds a single integer
            // Return null if this NestedInteger holds a nested list
            int GetInteger()
            {
                throw new NotImplementedException();
            }

            // Set this NestedInteger to hold a single integer.
            void SetInteger(int value)
            {
                throw new NotImplementedException();
            }

            // Set this NestedInteger to hold a nested list and adds a nested integer to it.
            public void Add(NestedInteger ni)
            {
                throw new NotImplementedException();
            }

            // @return the nested list that this NestedInteger holds, if it holds a nested list
            // Return null if this NestedInteger holds a single integer
            IList<NestedInteger> GetList()
            {
                throw new NotImplementedException();
            }
        }
    }
}
