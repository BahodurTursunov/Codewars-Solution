namespace _8kyu_Keep_up_the_hoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HoopCount(5));
            Console.WriteLine(HoopCount(20));
        }

        public static string HoopCount(int n)
        {
            if (n >= 10) return "Great, now move on to tricks";
            else return "Keep at it until you get it";
        }
    }
}
