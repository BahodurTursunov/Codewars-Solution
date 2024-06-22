namespace _8kyu_Is_it_even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool IsEven(double n) //=> n % 2 == 0;
        {
            if (n % 2 == 0)
                return true;
            else if (n == 0)
                return true;
            else
                return false;

            //return (n % 2 == 0) ? true : false;
        }
    }
}
