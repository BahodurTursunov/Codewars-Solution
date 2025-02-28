namespace _6kyu_Multiples_of_3_or_5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Solution(10)); // Выведет 23    
        }

        private static int Solution(int value)
        {

            if (value < 0)
            {
                return 0;
            }

            int sum = 0;

            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
