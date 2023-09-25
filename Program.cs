using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Integer ikilileri girin (örnek: 2 3 1 5 2 5 3 3): ");
        string input = Console.ReadLine();

        string[] numbers = input.Split(' ');

        Dictionary<int, int> sumDict = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i += 2)
        {
            if (i + 1 < numbers.Length && int.TryParse(numbers[i], out int num1) && int.TryParse(numbers[i + 1], out int num2))
            {
                int sum = num1 + num2;

                if (sumDict.ContainsKey(sum))
                {
                    sumDict[sum] += 1;
                }
                else
                {
                    sumDict[sum] = 1;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş.");
                return;
            }
        }

        Console.WriteLine("Output:");

        foreach (var entry in sumDict)
        {
            int sum = entry.Key;
            int count = entry.Value;

            if (count > 1)
            {
                Console.WriteLine(sum * sum);
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
