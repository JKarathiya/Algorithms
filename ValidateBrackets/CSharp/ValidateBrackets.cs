using System.Collections.Generic;

namespace ValidateBrackets
{
    public class Solution
    {
        public bool ValidateBrackets(string str)
        {
            if (string.IsNullOrEmpty(str))
                return true;

            Stack<char> brackets = new Stack<char>();
            foreach(var ch in str) {
                if (ch == '(')
                    brackets.Push(ch);
                else if (ch == ')')
                {
                    if (brackets.Count <= 0)
                        return false;
                    if (ch == ')' && brackets.Pop() != '(' )
                        return false;
                }
            }
            return brackets.Count == 0;
        }
    }
}
