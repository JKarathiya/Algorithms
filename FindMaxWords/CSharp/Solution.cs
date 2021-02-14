public class Solution
{
    public int FindMaxWords(string S)
    {
        string[] sentences = S.Split('.', '?', '!');
        int maxWords = 0;
        foreach (string sentence in sentences)
        {
            var words = sentence.Split(" ");
            var currWords = words.Length;
            foreach (string word in words)
            {
                if (word.Trim() == "")
                    currWords--;
            }
            maxWords = maxWords < currWords ? currWords : maxWords;
        }
        return maxWords;
    }
}