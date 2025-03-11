class Program
{
    static void Main()
    {
        // Считываем размер массива
        int n = int.Parse(Console.ReadLine());

        // Считываем массив
        string[] input = Console.ReadLine().Split();
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(input[i]);
        }

        // Используем словарь для подсчета количества вхождений каждого элемента
        Dictionary<int, int> countDict = new Dictionary<int, int>();
        foreach (int num in array)
        {
            if (countDict.ContainsKey(num))
            {
                countDict[num]++;
            }
            else
            {
                countDict[num] = 1;
            }
        }

        // Считаем количество уникальных элементов
        int uniqueCount = 0;
        foreach (var pair in countDict)
        {
            if (pair.Value == 1)
            {
                uniqueCount++;
            }
        }

        // Выводим результат
        Console.WriteLine(uniqueCount);
    }
}
