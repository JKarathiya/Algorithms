using System.Collections.Generic;

namespace TwiceOccurences
{
    public class Solution
    {
        public string TwiceOccurence(string S)
        {
            HashSet<char> charSet = new HashSet<char>();
            foreach (char character in S.ToCharArray())
            {
                if (charSet.Contains(character))
                    return character.ToString();
                charSet.Add(character);
            }
            return string.Empty;
        }
    }
}
