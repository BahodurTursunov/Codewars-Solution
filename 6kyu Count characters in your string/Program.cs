namespace _6kyu_Count_characters_in_your_string
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = "aba";
            var result = Count(input);

            foreach (var kvp in result)
            {
                Console.Write($"{kvp.Key}: {kvp.Value} ");
            }
        }

        public static Dictionary<char, int> Count(string str)
        {
            var characterCount = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (characterCount.ContainsKey(c))
                {
                    characterCount[c]++;
                }
                else
                {
                    characterCount[c] = 1;
                }
            }

            return characterCount;
        }
    }
}


#region Can Be
/* 
 * return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
 */

/*
   public static Dictionary<char, int> Count(string str) => str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
 */
#endregion
