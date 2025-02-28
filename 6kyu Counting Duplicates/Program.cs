namespace _6kyu_Counting_Duplicates
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(DuplicateCount("abcde")); // 0
            Console.WriteLine(DuplicateCount("aabbcde")); // 2
            Console.WriteLine(DuplicateCount("aabBcde")); // 2
            Console.WriteLine(DuplicateCount("indivisibility")); // 1
            Console.WriteLine(DuplicateCount("Indivisibilities")); // 2
            Console.WriteLine(DuplicateCount("aA11")); // 2
            Console.WriteLine(DuplicateCount("ABBA")); // 2
        }

        private static int DuplicateCount(string str)
        {
            //return str.ToLower().GroupBy(c => c).Count(g => g.Count() > 1); //another way to solve the problem

            var charCounts = new Dictionary<char, int>();
            str = str.ToLower();

            foreach (char c in str)
            {
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts[c] = 1;
                }
            }

            int duplicates = 0;

            foreach (var count in charCounts.Values)
            {
                if (count > 1)
                {
                    duplicates++;
                }
            }
            return duplicates;
        }
    }
}

