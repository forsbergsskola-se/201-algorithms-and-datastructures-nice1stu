using NUnit.Framework;
using TurboCollections;

[TestFixture]
public class TurboAverageTests
{
    [Test]
    public void TestCalculateAverage()
    {
        Assert.That(TurboAverage.CalculateAverage(new double[] { 1, 2, 3 }), Is.EqualTo(2));
        Assert.That(TurboAverage.CalculateAverage(new double[] { 69, 13, 666, 7 }), Is.EqualTo(188.75));
        Assert.That(TurboAverage.CalculateAverage(new double[] { -1, 0, 1 }), Is.EqualTo(0));
        Assert.That(TurboAverage.CalculateAverage(new double[] { 1, 1, 1, 1 }), Is.EqualTo(1));
        Assert.That(TurboAverage.CalculateAverage(new double[] { 2.5, 3.5, 4.5 }), Is.EqualTo(3.5));
    }
}