namespace _7kyu_Check_three_and_two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = { "a", "a", "a", "b", "b" };
            string[] arr2 = { "a", "b", "c", "b", "c" };
            string[] arr3 = { "a", "a", "a", "a", "a" };

            Console.WriteLine(CheckArray(arr1)); // Output: True
            Console.WriteLine(CheckArray(arr2)); // Output: False
            Console.WriteLine(CheckArray(arr3)); // Output: False
        }

        public static bool CheckArray(string[] arr)
        {
            // Create a dictionary to count occurrences of each character
            Dictionary<string, int> counts = new Dictionary<string, int>();

            // Count each character
            foreach (string s in arr)
            {
                if (counts.ContainsKey(s))
                {
                    counts[s]++;
                }
                else
                {
                    counts[s] = 1;
                }
            }

            bool hasThree = false;
            bool hasTwo = false;

            foreach (var count in counts.Values)
            {
                if (count == 3)
                {
                    hasThree = true;
                }
                else if (count == 2)
                {
                    hasTwo = true;
                }
            }

            return hasThree && hasTwo;
        }
    }
}


#region Можно было использовать LINQ
/*
var gData = array.GroupBy(x => x).Select(x => x.Count()).ToList();
return (gData.Any(x => x == 3) && gData.Any(x => x == 2));*/

//return array.GroupBy(s => s).All(g => new[] {2, 3}.Contains(g.Count()));
#endregion