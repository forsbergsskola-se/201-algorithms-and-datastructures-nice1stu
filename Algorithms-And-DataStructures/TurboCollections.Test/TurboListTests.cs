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

        Assert.That(list.Get(0), Is.EqualTo(13));
        Assert.That(list.Get(1), Is.EqualTo(5));
        Assert.That(list.Get(4), Is.EqualTo(69));
        Assert.That(list.Get(3), Is.EqualTo(101));
        Assert.That(list.Get(2), Is.EqualTo(100));
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

        Assert.That(list.Get(0), Is.EqualTo(13));
        Assert.That(list.Get(1), Is.EqualTo(5));
        Assert.That(list.Get(2), Is.EqualTo(999));
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

        Assert.That(list.Count, Is.EqualTo(0));
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

        Assert.That(list.IndexOf(69), Is.EqualTo(4));
        Assert.That(list.IndexOf(999), Is.EqualTo(-1));
        Assert.That(list.IndexOf(13), Is.EqualTo(0));
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

        Assert.That(list.Count, Is.EqualTo(4));
        Assert.That(list.Get(2), Is.EqualTo(101));
    }

}