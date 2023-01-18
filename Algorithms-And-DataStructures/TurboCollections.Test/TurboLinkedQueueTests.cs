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
                
        stack.Enqueue(1);
        stack.Enqueue(5);
        stack.Enqueue(13);
                
        CollectionAssert.AreEqual(stack, new[]{1, 5, 13});
    }
}