namespace TurboCollections.Test;

public class TurboLinkedQueueTests
{
    [Test]
    public void CountTest()
    {

    }

    [Test]
    public void EnqueueTest()
    {
        var stack = new TurboLinkedQueue<int>();
                
        stack.Enqueue(100);
        stack.Enqueue(5);
        stack.Enqueue(13);
        stack.Enqueue(101);
        stack.Enqueue(54);
                
        CollectionAssert.AreEqual(stack, new[]{100, 5, 13, 101, 54});
    }
    
    [Test]
    public void PeekTestReturn1stValue()
    {
        var stack = new TurboLinkedQueue<int>();
        stack.Enqueue(100);
        stack.Enqueue(5);
        stack.Enqueue(13);
        stack.Enqueue(101);
        stack.Enqueue(54);

        var result = stack.Peek();

        Assert.AreEqual(100, result);
        Assert.AreEqual(100, result);
    }
}