namespace TurboCollections;

public class TurboAverage
{
    public static double CalculateAverage(double[] arr)
    {
        double total = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            total += arr[i];
        }

        return total / arr.Length;
    }
}