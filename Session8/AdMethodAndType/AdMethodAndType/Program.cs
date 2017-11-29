using System;

namespace AdMethodAndType
{
    static class Program
    {
        static string FormatString(this string result)
        {
            if (result.Length > 0)
            {
                char[] s = result.ToCharArray();
                s[0] = char.ToLower(s[0]);
                return new string(s);
            }
            return result;
        }
        static void Main(string[] args)
        {
            string s = "Ha Noi";
            Console.WriteLine(s.FormatString());
        }
    }
}
