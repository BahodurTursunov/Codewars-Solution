namespace _8kyu_Short_Long_Short
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("1", "22")); // Output: "1221"
            Console.WriteLine(Solution("22", "1")); // Output: "1221"
            Console.WriteLine(Solution("abc", "defgh")); // Output: "abcdefghabc"
            Console.WriteLine(Solution("", "xyz")); // Output: "xyz"
        }
        public static string Solution(string a, string b)
        {
            if (a.Length < b.Length)
            {
                return a + b + a;
            }
            else
            {
                return b + a + b;
            }
        }
    }
}
