namespace TurboCollections;

//the Fibonacci sequence, in which each number is the sum of the two preceding ones.

public class TurboFibonacci
{
    //Recursive Fn = Fn−1+Fn−2
    public static int FibonacciRecursive(int nthNumber) 
    {
        if (nthNumber == 0)
        {
            return 0;
        }
        else if (nthNumber == 1)
        {
            return 1;
        }
        return FibonacciRecursive(nthNumber-1) + FibonacciRecursive(nthNumber-2);
    }
}