public class RomanConverter
{
    private static readonly Dictionary<int, string> RomanMap = new()
    {
        {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"},
        {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"},
        {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"},
        {1, "I"}
    };

    public static string ToRoman(int num)
    {
        if (num < 1 || num >= 4000)
        {
            throw new ArgumentOutOfRangeException("Value must be between 1 and 3999");
        }

        var result = string.Empty;

        foreach (var kvp in RomanMap)
        {
            while (num >= kvp.Key)
            {
                result += kvp.Value;
                num -= kvp.Key;
            }
        }

        return result;
    }

    public static int FromRoman(string roman)
    {
        if (string.IsNullOrEmpty(roman))
        {
            throw new ArgumentException("Input cannot be null or empty");
        }

        var romanToInteger = new Dictionary<char, int>
        {
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
            {'C', 100}, {'D', 500}, {'M', 1000}
        };

        int total = 0;
        int prevValue = 0;

        foreach (char c in roman)
        {
            if (!romanToInteger.ContainsKey(c))
            {
                throw new ArgumentException("Invalid Roman numeral character");
            }

            int currentValue = romanToInteger[c];

            if (currentValue > prevValue)
            {
                total += currentValue - (2 * prevValue);
            }
            else
            {
                total += currentValue;
            }

            prevValue = currentValue;
        }

        return total;
    }

    public static void Main()
    {
        Console.WriteLine(ToRoman(2000)); // MM
        Console.WriteLine(ToRoman(1666)); // MDCLXVI
        Console.WriteLine(ToRoman(86));   // LXXXVI
        Console.WriteLine(ToRoman(1));    // I

        Console.WriteLine(FromRoman("MM"));       // 2000
        Console.WriteLine(FromRoman("MDCLXVI")); // 1666
        Console.WriteLine(FromRoman("LXXXVI"));  // 86
        Console.WriteLine(FromRoman("I"));       // 1
    }
}
