namespace _5qyu_5ROT13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Kata.Rot13("Va gur ryringbef, gur rkgebireg ybbxf ng gur BGURE thl'f fubrf."));
        }

        public class Kata
        {
            public static string Rot13(string input)
            {
                return new string(input.Select(c =>
                {
                    if (c >= 'a' && c <= 'z')
                    {
                        return (char)('a' + ((c - 'a' + 13) % 26));
                    }

                    if (c >= 'A' && c <= 'Z')
                    {
                        return (char)('A' + ((c - 'A' + 13) % 26));
                    }

                    return c;
                }).ToArray());
            }
        }

    }
}
