namespace _7_kyu_Clothes_size_number_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 10, 3, 10, 10 };

            Console.WriteLine(SumNoDuplicates(arr));
        }

        public static int SumNoDuplicates(int[] arr)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (int element in arr)
            {
                if (counts.ContainsKey(element))
                {
                    counts[element]++;
                }
                else
                {
                    counts[element] = 1;
                }
            }

            int sum = 0;

            foreach (var element in counts)
            {
                if (element.Value == 1)
                {
                    sum += element.Key;
                }
            }
            return sum;
        }
    }
}
