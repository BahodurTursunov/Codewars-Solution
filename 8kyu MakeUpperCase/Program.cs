namespace _8kyu_MakeUpperCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakeUpperCase("hello world!"));
        }

        public static string MakeUpperCase(string str)
        {
            return str.ToUpper();
        }
    }
}
