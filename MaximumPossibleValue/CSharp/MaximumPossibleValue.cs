using System;
public class Solution
{
    public int MaximumPossibleValue(int n)
    {
        int abs = n >= 0 ? 1 : -1;
        int maxValue = -8000;
        string additionalDigit = "5";
        string str = Math.Abs(n).ToString();
        for (int i = 0; i < str.Length; i++)
        {
            int currentValue = abs * Int32.Parse(str.Substring(0, i) + additionalDigit + str.Substring(i, str.Length - i));
            if (currentValue > maxValue)
                maxValue = currentValue;
        }
        return maxValue;
    }
}