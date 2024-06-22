namespace _8kyu_get_character_from_ASCII_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetChar(65));
            Console.WriteLine(GetChar(97));
            Console.WriteLine(GetChar(96));
        }
        public static char GetChar(int charcode) // => (char)charcode;
        {
            return Convert.ToChar(charcode);
            // return (char)charcode;
        }
    }
}
