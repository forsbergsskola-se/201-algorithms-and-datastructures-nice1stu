namespace TurboCollections.Test;

public class TurboQueueTests
{
    [Test]
    public void EnqueueTestcheckStoredValuesAre()
    {
        var queue = new TurboQueue<int>();
                
        queue.Enqueue(100);
        queue.Enqueue(5);
        queue.Enqueue(13);
        queue.Enqueue(101);
        queue.Enqueue(54);
                
        Assert.That(new[]{100, 5, 13, 101, 54}, Is.EqualTo(queue));
    }
    
    [Test]
    public void PeekTestReturn1stValue()
    {
        var queue = new TurboQueue<int>();
        queue.Enqueue(100);
        queue.Enqueue(5);
        queue.Enqueue(13);
        queue.Enqueue(101);
        queue.Enqueue(54);

        var result = queue.Peek();

        Assert.AreEqual(100, result);
    }
    
    [Test]
    public void DequeueTest()
    {
        var queue = new TurboQueue<int>();
        queue.Enqueue(100);
        queue.Enqueue(5);
        queue.Enqueue(13);
        queue.Enqueue(101);
        queue.Enqueue(54);

        queue.Dequeue();
        
        Assert.AreEqual(5, queue.Peek());
    }

    [Test]

    public void ClearTest()
    {
        var queue = new TurboQueue<int>();
        queue.Enqueue(100);
        queue.Enqueue(5);
        queue.Enqueue(13);
        queue.Enqueue(101);
        queue.Enqueue(54);
        
        queue.Clear();
        
        Assert.AreEqual(0, queue.Count);
    }

    [Test]
    public void CountTest()
    {
        var queue = new TurboQueue<int>();
        queue.Enqueue(100);
        queue.Enqueue(5);
        queue.Enqueue(13);
        queue.Enqueue(101);
        queue.Enqueue(54);
        
        Assert.AreEqual(5, queue.Count);
    }
}