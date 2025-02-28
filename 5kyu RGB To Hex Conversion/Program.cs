namespace _5kyu_RGB_To_Hex_Conversion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Rgb(255, 255, 255));
        }
        public static string Rgb(int r, int g, int b)
        {
            int Clamp(int value)
            {
                if (value < 0)
                {
                    return 0;
                }

                if (value > 255)
                {
                    return 255;
                }

                return value;
            }

            r = Clamp(r);
            g = Clamp(g);
            b = Clamp(b);

            return $"{r:X2}{g:X2}{b:X2}";
        }
    }
}

#region Можно было так сделать
/*
   public static string Rgb(int r, int g, int b) 
  {
    	r = Math.Max(Math.Min(255, r), 0);
    	g = Math.Max(Math.Min(255, g), 0);
    	b = Math.Max(Math.Min(255, b), 0);
      return String.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
  }
 */
/*
 *   public static string Rgb(int r, int g, int b)
        {
            return limitValue(r) + limitValue(g) + limitValue(b);
        }

        public static string limitValue(int n)
        {
            if (n < 0) n = 0;
            if (n > 255) n = 255;
            return n.ToString("X2");
        }
*/

/*
  public static string Rgb(int r, int g, int b) 
  {
    return Math.Clamp(r, 0, 255).ToString("X2") + Math.Clamp(g, 0, 255).ToString("X2") + Math.Clamp(b, 0, 255).ToString("X2");
  }
*/


/*
  public static string Rgb(int r, int g, int b) 
  {
      return $"{(r > 255 ? 255 : r < 0 ? 0 : r):X2}" + 
             $"{(g > 255 ? 255 : g < 0 ? 0 : g):X2}" +
             $"{(b > 255 ? 255 : b < 0 ? 0 : b):X2}";
  }
*/
#endregion