using System.Collections.Generic;

public class Solution
{
    public int maxTrailing(List<int> levels)
    {
        int minValue = levels[0];
        int maxValue = -1;

        for (int i = 0; i < levels.Count; i++)
        {
            if (levels[i] < minValue)
                minValue = levels[i];
            int result = levels[i] - minValue;
            if (result != 0 && result > maxValue)
                maxValue = result;
        }

        return maxValue;
    }
}