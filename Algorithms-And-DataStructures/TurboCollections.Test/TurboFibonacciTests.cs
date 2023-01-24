using System.Diagnostics;

namespace TurboCollections.Test;

public class TurboFibonacciTests
{
    [Test]
    public void TestFibonacciRecursive()
    {
        Stopwatch stopwatch = new Stopwatch();
        int n = 40;

        stopwatch.Start();
        int result1 = TurboFibonacci.FibonacciRecursive(n);
        stopwatch.Stop();
        Console.WriteLine("Recursive: " + result1);
        Console.WriteLine("Time taken: " + stopwatch.ElapsedMilliseconds + "ms");
            
        Assert.That(TurboFibonacci.FibonacciRecursive(0), Is.EqualTo(0));
        Assert.That(TurboFibonacci.FibonacciRecursive(1), Is.EqualTo(1));
        Assert.That(TurboFibonacci.FibonacciRecursive(2), Is.EqualTo(1));
        Assert.That(TurboFibonacci.FibonacciRecursive(3), Is.EqualTo(2));
        Assert.That(TurboFibonacci.FibonacciRecursive(4), Is.EqualTo(3));
        Assert.That(TurboFibonacci.FibonacciRecursive(40), Is.EqualTo(102334155));
    }
    
    [Test]
    public void TestFibonacciIterative()
    {
        Stopwatch stopwatch = new Stopwatch();
        int n = 40;

        stopwatch.Start();
        int result1 = TurboFibonacci.FibonacciIterative(n);
        stopwatch.Stop();
        Console.WriteLine("Iterative: " + result1);
        Console.WriteLine("Time taken: " + stopwatch.ElapsedMilliseconds + "ms");
            
        Assert.That(TurboFibonacci.FibonacciRecursive(0), Is.EqualTo(0));
        Assert.That(TurboFibonacci.FibonacciRecursive(1), Is.EqualTo(1));
        Assert.That(TurboFibonacci.FibonacciRecursive(2), Is.EqualTo(1));
        Assert.That(TurboFibonacci.FibonacciRecursive(3), Is.EqualTo(2));
        Assert.That(TurboFibonacci.FibonacciRecursive(4), Is.EqualTo(3));
        Assert.That(TurboFibonacci.FibonacciRecursive(40), Is.EqualTo(102334155));
    }
}