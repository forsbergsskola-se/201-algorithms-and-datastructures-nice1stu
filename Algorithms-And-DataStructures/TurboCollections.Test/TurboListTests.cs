namespace TurboCollections.Test;

[TestFixture]
public class TurboLinkedListTests
{
    private ITurboList.TurboLinkedList<int>? _list;

    [SetUp]
    public void SetUp()
    {
        _list = new ITurboList.TurboLinkedList<int>();
    }
    
    [Test]
    public void TestGetValueFromCorrectIndex()
    {
        if (_list == null) return;
        _list.Add(13);
        _list.Add(5);
        _list.Add(100);
        _list.Add(101);
        _list.Add(69);

        Assert.That(_list.Get(0), Is.EqualTo(13));
        Assert.That(_list.Get(1), Is.EqualTo(5));
        Assert.That(_list.Get(4), Is.EqualTo(69));
        Assert.That(_list.Get(3), Is.EqualTo(101));
        Assert.That(_list.Get(2), Is.EqualTo(100));
    }
    
    [Test]
    public void TestSetIteminCorrectIndex()
    {
        if (_list == null) return;
        _list.Add(13);
        _list.Add(5);
        _list.Add(100);
        _list.Add(101);
        _list.Add(69);

        _list.Set(0, 13);
        _list.Set(1, 5);
        _list.Set(2, 999);

        Assert.That(_list.Get(0), Is.EqualTo(13));
        Assert.That(_list.Get(1), Is.EqualTo(5));
        Assert.That(_list.Get(2), Is.EqualTo(999));
    }
    [Test]
    public void TestCountIsZeroAfterClear()
    {
        if (_list == null) return;
        _list.Add(13);
        _list.Add(5);
        _list.Add(100);
        _list.Add(101);
        _list.Add(69);

        _list.Clear();

        Assert.That(_list.Count, Is.EqualTo(0));
    }
    
    [Test]
    public void TestRemoveIndexAt()
    {

    }
    
    [Test]
    public void TestContainsValueAtCorrectIndex()
    {
        if (_list == null) return;
        _list.Add(13);
        _list.Add(5);
        _list.Add(100);
        _list.Add(101);
        _list.Add(69);

        Assert.IsTrue(_list.Contains(69));
        Assert.IsFalse(_list.Contains(999));
    }
    
    [Test]
    public void TestIndexOf()
    {
        if (_list == null) return;
        _list.Add(13);
        _list.Add(5);
        _list.Add(100);
        _list.Add(101);
        _list.Add(69);

        Assert.That(_list.IndexOf(69), Is.EqualTo(4));
        Assert.That(_list.IndexOf(999), Is.EqualTo(-1));
        Assert.That(_list.IndexOf(13), Is.EqualTo(0));
    }
    
    [Test]
    public void TestRemove()
    {
        if (_list == null) return;
        _list.Add(13);
        _list.Add(5);
        _list.Add(100);
        _list.Add(101);
        _list.Add(69);

        _list.Remove(2);

        Assert.That(_list.Count, Is.EqualTo(4));
        Assert.That(_list.Get(2), Is.EqualTo(101));
    }
}