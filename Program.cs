using System.Text;
string s = "hello";
Console.WriteLine(ReverseVowels(s));
string ReverseVowels(string s)
{
    Stack<char> stack = new Stack<char>();
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < s.Length; i++)
    {
        char ch = s[i];
        if ("aeiouAEIOU".Contains(ch))
        {
            stack.Push(ch);
        }
    }
    for (int i = 0; i < s.Length; i++)
    {
        char ch = s[i];
        if ("aeiouAEIOU".Contains(ch))
        {
            sb.Append(stack.Pop());
        }
        else
        {
            sb.Append(ch);
        }
    }

    return sb.ToString();
}