namespace _6kyu_Highest_Rank_Number_in_an_Array
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = { 12, 10, 8, 12, 7, 6, 4, 10, 12 };

            var res = HighestRank(arr);

            Console.WriteLine(res);
        }


        /* public static int HighestRank(int[] arr)
         {
             Dictionary<int, int> frequency = new Dictionary<int, int>();

             foreach (var num in arr)
             {
                 if (frequency.ContainsKey(num))
                 {
                     frequency[num]++;
                 }
                 else
                 {
                     frequency[num] = 1;
                 }
             }

             int maxFrequency = frequency.Values.Max();
             int mostFrequent = int.MinValue;

             foreach (var pair in frequency)
             {
                 if (pair.Value == maxFrequency)
                 {
                     mostFrequent = Math.Max(mostFrequent, pair.Key);
                 }
             }

             return mostFrequent;
         }
         */
        #region LINQ

        public static int HighestRank(int[] arr)
        {
            return arr
              .GroupBy(i => i)
              .OrderByDescending(gr => gr.Count())
              .ThenByDescending(gr => gr.Key)
              .Select(gr => gr.Key)
              .First();
        }
        #endregion



    }
}
