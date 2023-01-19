//Reference TurboCollections
//Use TurboLinkedQueue
//The User repeatedly has the following options:

//[s]kip to next song: If there is another song in the queue, it prints $"Now Playing {songName}.". else, it says "No more songs in the Queue. Add new Songs to the Queue first."
//[a]dd new song to the queue: The application asks for a Song Name and then adds it to the Queue.

using System.Collections;
using NUnit.Framework;

namespace TurboCollections.Test;
public class SpotifySongQueue
{
    [Test]
    public void EnqueueTestcheckStoredValues()
    {
        var queue = new TurboLinkedQueue<int>();
                
        queue.Enqueue(100);
        queue.Enqueue(5);
        queue.Enqueue(13);
        queue.Enqueue(101);
        queue.Enqueue(54);
                
        CollectionAssert.AreEqual(queue, new[]{100, 5, 13, 101, 54});
    }
    
    [Test]
    public void PeekTestReturn1stValue()
    {
        var queue = new TurboLinkedQueue<int>();
        queue.Enqueue(100);
        queue.Enqueue(5);
        queue.Enqueue(13);
        queue.Enqueue(101);
        queue.Enqueue(54);

        var result = queue.Peek();

        Assert.AreEqual(100, result);
        Assert.AreEqual(100, result);
    }
    
    [Test]
    public void DequeueTest()
    {
        var queue = new TurboLinkedQueue<int>();
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
        var queue = new TurboLinkedQueue<int>();
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
        var queue = new TurboLinkedQueue<int>();
        queue.Enqueue(100);
        queue.Enqueue(5);
        queue.Enqueue(13);
        queue.Enqueue(101);
        queue.Enqueue(54);
        
        Assert.AreEqual(5, queue.Count);
    }
}