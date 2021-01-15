using System;
public class Solution
{
    public int CalculatePascalLayerTotal(int layer)
    {
        if (layer < 0) return -1;

        long result = 0;
        long total = 0;

        for (int i = 0; i <= layer; i++)
        {
            total = (layer == i || i == 0) ? 1 : total * (layer - i + 1) / i;
            result += (int)total;
        }

        return (result <= Int32.MaxValue ? (int)result : -1);
    }
}