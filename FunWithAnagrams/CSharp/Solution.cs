using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public List<string> FunWithAnagrams(List<string> text)
    {
        HashSet<string> tempset = new HashSet<string>();
        List<string> result = new List<string>();

        for (int i = 0; i < text.Count; i++)
        {
            var tempString = String.Concat(text[i].OrderBy(c => c));
            if (!tempset.Contains(tempString))
            {
                result.Add(text[i]);
                tempset.Add(tempString);
            }
        }
        return result.OrderBy(x => x).ToList();
    }
}