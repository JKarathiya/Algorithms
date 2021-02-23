public class Solution
{
    public int[] UniqueIntegers(int N)
    {
        int[] result = new int[N];
        for (int i = 0; i < N - 1; i = i + 2)
        {
            result[i] = i + 1;
            result[i + 1] = -result[i];
        }
        return result;
    }
}