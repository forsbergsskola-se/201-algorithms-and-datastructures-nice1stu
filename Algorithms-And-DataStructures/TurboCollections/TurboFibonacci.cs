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
    
    //Iterative
    public static int FibonacciIterative(int nthNumber)
    {
        int a = 0, b = 1, c;
        for (int i = 0; i < nthNumber; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return a;
    }
}