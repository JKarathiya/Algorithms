using System;
public class Solution
{
    public int MaximumPossibleValue(int n)
    {
        int abs = n >= 0 ? 1 : -1;
        int max = -8000;
        var str = Math.Abs(n).ToString();
        for (int i = 0; i < str.Length; i++)
        {
            int val = abs * Int32.Parse(str.Substring(0, i) + "5" + str.Substring(i, str.Length - i));
            if (val > max)
                max = val;
        }
        return max;
    }
}