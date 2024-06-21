namespace _8kyu_All_Star_Code_Challenge__18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrCount("Hello world", 'o'));
        }
        public static int StrCount(string str, char letter)
        {
            int count = 0;
            foreach (var c in str)
            {
                if (c == letter)
                {
                    count++;
                }
            }
            return count;
        }
    }



}

