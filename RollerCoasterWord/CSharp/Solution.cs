public class Solution
{
    public bool RollercoasterWord(string input)
    {
        if (input.Length == 1) return true;

        bool stepPositive = false;
        string word = input.ToLower();

        if ((int)word[0] < (int)word[1])
        {
            stepPositive = true;
        }

        for (int i = 0; i < word.Length - 1; i++)
        {
            if (stepPositive && !((int)word[i] < (int)word[i + 1]))
            {
                return false;
            }
            if (!stepPositive && !((int)word[i] > (int)word[i + 1]))
            {
                return false;
            }
            stepPositive = !stepPositive;
        }
        return true;
    }
}