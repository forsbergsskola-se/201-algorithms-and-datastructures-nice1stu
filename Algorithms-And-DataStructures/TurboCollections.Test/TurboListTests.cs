namespace TurboCollections.Test;

[TestFixture]
public class TurboLinkedListTests
{
    private ITurboList.TurboLinkedList<int> list;

    [SetUp]
    public void SetUp()
    {
        list = new ITurboList.TurboLinkedList<int>();
    }
    
    [Test]
    public void TestGetValueFromCorrectIndex()
    {
        list.Add(13);
        list.Add(5);
        list.Add(100);
        list.Add(101);
        list.Add(69);

        Assert.AreEqual(13, list.Get(0));
        Assert.AreEqual(5, list.Get(1));
        Assert.AreEqual(69, list.Get(4));
        Assert.AreEqual(101, list.Get(3));
        Assert.AreEqual(100, list.Get(2));
    }
    
    [Test]
    public void TestSetIteminCorrectIndex()
    {
        list.Add(13);
        list.Add(5);
        list.Add(100);
        list.Add(101);
        list.Add(69);

        list.Set(0, 13);
        list.Set(1, 5);
        list.Set(2, 999);

        Assert.AreEqual(13, list.Get(0));
        Assert.AreEqual(5, list.Get(1));
        Assert.AreEqual(999, list.Get(2));
    }
    [Test]
    public void TestCountIsZeroAfterClear()
    {
        list.Add(13);
        list.Add(5);
        list.Add(100);
        list.Add(101);
        list.Add(69);

        list.Clear();

        Assert.AreEqual(0, list.Count);
    }
    
    [Test]
    public void TestRemoveIndexAT()
    {

    }
    
    [Test]
    public void TestContainsValueAtCorrectIndex()
    {
        list.Add(13);
        list.Add(5);
        list.Add(100);
        list.Add(101);
        list.Add(69);

        Assert.IsTrue(list.Contains(69));
        Assert.IsFalse(list.Contains(999));
    }
    
    [Test]
    public void TestIndexOf()
    {
        list.Add(13);
        list.Add(5);
        list.Add(100);
        list.Add(101);
        list.Add(69);

        Assert.AreEqual(4, list.IndexOf(69));
        Assert.AreEqual(-1, list.IndexOf(999));
        Assert.AreEqual(0, list.IndexOf(13));
    }
    
    [Test]
    public void TestRemove()
    {
        list.Add(13);
        list.Add(5);
        list.Add(100);
        list.Add(101);
        list.Add(69);

        list.Remove(2);

        Assert.AreEqual(4, list.Count);
        Assert.AreEqual(101, list.Get(2));
    }

}