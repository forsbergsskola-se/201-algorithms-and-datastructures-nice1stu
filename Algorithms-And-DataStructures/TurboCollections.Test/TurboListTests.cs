using NUnit.Framework;
using System;
using System.Linq;
using TurboCollections;

[TestFixture]
public class TurboLinkedListTests
{
    private ITurboList<int> list;

    [SetUp]
    public void SetUp()
    {
        list = new ITurboList.TurboLinkedList<int>();
    }
    
    [Test]
    public void TestClear()
    {
        list.Add(13);
        list.Add(5);
        list.Add(100);
        list.Add(101);
        list.Add(69);

        list.Clear();

        Assert.AreEqual(0, list.Count);
    }

}