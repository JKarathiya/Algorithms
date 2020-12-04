using System.Linq;
public class Solution
{
    public int CalculatePascalLayerTotal(int layer)
    {
        if (layer < 0) return -1;

        int[] arr = new int[layer + 1];
        int total = 0;
        for (int i = 0; i <= layer; i++)
        {
            total = (layer == i || i == 0) ? 1 : total * (layer - i + 1) / i;
            arr[i] = total;
        }

        return arr.Sum();
    }
}