public class Solution
{
    public int HowManyFlips(string target)
    {
        char curr = '1';
        int count = 0;
        for (int i = 0; i < target.Length; i++)
        {
            if (target[i] == curr)
            {
                count++;
                curr = (char)(48 + (curr + 1) % 2);
            }
        }
        return count;
    }
}