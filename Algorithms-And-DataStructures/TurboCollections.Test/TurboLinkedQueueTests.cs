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
        var stack = new TurboLinkedStack<int>();
                
        stack.Push(1);
        stack.Push(5);
        stack.Push(13);
                
        CollectionAssert.AreEqual(stack, new[]{13, 5, 1});
    }
}