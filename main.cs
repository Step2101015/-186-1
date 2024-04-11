/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Program
{
    static void Main()
    {
        int[] coinValues = { 1, 2, 5, 10 }; // Номиналы монет
        int[] coinCounts = new int[coinValues.Length]; // Количество монет каждого номинала

        // Ввод количества монет каждого номинала
        for (int i = 0; i < coinValues.Length; i++)
        {
            Console.Write($"Введите количество монет номинала {coinValues[i]}: ");
            coinCounts[i] = int.Parse(Console.ReadLine());
        }

        // Вычисление общей суммы монет
        int totalSum = 0;
        for (int i = 0; i < coinValues.Length; i++)
        {
            totalSum += coinValues[i] * coinCounts[i];
        }

        Console.WriteLine($"Общая сумма монет: {totalSum}");
    }
}