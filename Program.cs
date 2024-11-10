using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строки через запятую:");
        string input = Console.ReadLine();
        
        // Разделяем введенные данные на массив строк
        string[] inputArray = input.Split(',');

        List<string> outputList = new List<string>();

        foreach (string item in inputArray)
        {
            // Убираем пробелы и проверяем длину строки
            if (item.Trim().Length <= 3)
            {
                outputList.Add(item.Trim());
            }
        }

        string[] outputArray = outputList.ToArray();

        Console.WriteLine("Результат:");
        foreach (string item in outputArray)
        {
            Console.WriteLine(item);
        }
    }
}
