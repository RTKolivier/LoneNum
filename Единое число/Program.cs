using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите числа через пробел:");
        Console.WriteLine("Условие: целочисленный массив, в котором ровно два элемента появляются только один раз, а все остальные элементы появляются ровно дважды.");
        string input = Console.ReadLine();
        int[] nums = input.Split(' ').Select(int.Parse).ToArray();
        var result = FindSingleNumbers(nums);
        Console.WriteLine($"[{string.Join(",", result)}]");
    }

    static int[] FindSingleNumbers(int[] nums)
    {
        Dictionary<int, int> frequency = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (frequency.ContainsKey(num))
                frequency[num]++;
            else
                frequency[num] = 1;
        }

        return frequency.Where(pair => pair.Value == 1)
                       .Select(pair => pair.Key)
                       .ToArray();
    }
}
