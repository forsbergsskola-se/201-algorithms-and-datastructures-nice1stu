﻿namespace TurboCollections;

public class TurboMaths
{
    public static void SayHello()
    {
        Console.WriteLine($"Hello, I'm {typeof(TurboMaths)}");
    }

    public static List<int> GetOddNumbersList(int maxNumber)
    {
        List<int> oddNumbers = new List<int>();
        for (int i = 0; i < maxNumber; i++)
        {
            if (i % 2 == 1)
            {
                oddNumbers.Add(i);
            }
        }
        return oddNumbers;
    }
    
    public static IEnumerable<int> GetOddNumbers(int maxNumber)
    {
        for (int i = 0; i < maxNumber; i++)
        {
            if (i % 2 == 1)
            {
                yield return i;
            }

        }
    }
}