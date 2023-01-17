namespace TurboCollections;

using System.Collections;

public static class TurboMaths
{
    public static void SayHello()
    {
        Console.WriteLine($"Hello, I'm {typeof(TurboMaths)}");
    }

    static IEnumerable GetOddNumbers(int iterator)
    {
        for (int i = 0; i < iterator; i++)
        {
            yield return i;
        }
    }
}