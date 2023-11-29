namespace ReverseString
{
    public class Solution
    {
        public string ReverseString(string str)
        {
            char[] ch = str.ToCharArray();
            int length = str.Length;
            int halfLength = length / 2;
            for (int i=0; i<halfLength; i++)
            {
                char temp = ch[i];
                ch[i] = ch[length-1-i];
                ch[length-1-i] = temp;
            }
            return new string(ch);
        }
    }
}
