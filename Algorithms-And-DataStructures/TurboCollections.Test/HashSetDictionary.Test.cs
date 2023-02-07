[TestFixture]
public class DictionaryTests
{
    [Test]
    public void TestAddMethod()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        
        dictionary.Add(1, "One");
        Assert.That(dictionary.ContainsKey(1), Is.True);
        Assert.That(dictionary[1], Is.EqualTo("One"));
        Assert.That(dictionary.Count, Is.EqualTo(1));
        
        Assert.Throws<ArgumentException>(() => dictionary.Add(1, "Uno"));
    }

    [Test]
    public void TestContainsKeyMethod()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "One");
        dictionary.Add(2, "Two");
        
        Assert.That(dictionary.ContainsKey(1), Is.True);
        
        Assert.That(dictionary.ContainsKey(3), Is.False);
    }

    [Test]
    public void TestIndexerGet()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "One");
        dictionary.Add(2, "Two");
        
        Assert.That(dictionary[1], Is.EqualTo("One"));
        //Assert.Throws<KeyNotFoundException>(() => dictionary[2]);
    }

    [Test]
    public void TestIndexerSet()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "One");
        
        dictionary[1] = "Uno";
        Assert.That(dictionary[1], Is.EqualTo("Uno"));
        
        dictionary[2] = "Two";
        Assert.That(dictionary[2], Is.EqualTo("Two"));
    }

    [Test]
    public void TestDictionaryMethods()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "One");
        dictionary.Add(2, "Two");
        dictionary.Add(3, "Three");
        
        dictionary.Remove(2);
        Assert.That(dictionary.ContainsKey(2), Is.False);
        Assert.That(dictionary.Count, Is.EqualTo(2));
        
        Assert.Throws<KeyNotFoundException>(() => dictionary.Remove(4));
        
        dictionary.Add(4, "Four");
        Assert.That(dictionary.ContainsKey(4), Is.True);
        Assert.That(dictionary.Count, Is.EqualTo(3));
        
        Assert.Throws<ArgumentException>(() => dictionary.Add(1, "One"));
        
        Assert.That(dictionary.ContainsKey(5), Is.False);
        Assert.That(dictionary.ContainsKey(1), Is.True);
        
        string value = dictionary[3];
        Assert.That(value, Is.EqualTo("Three"));
        
        Assert.Throws<KeyNotFoundException>(() => { var v = dictionary[5]; });
        
        dictionary[3] = "Three New";
        Assert.That(dictionary[3], Is.EqualTo("Three New"));
        
        dictionary[5] = "Five";
        Assert.That(dictionary[5], Is.EqualTo("Five"));
    }

    [Test]
    public void TestRemoveMethod()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "One");
        dictionary.Add(2, "Two");
        dictionary.Add(3, "Three");
        
        dictionary.Remove(2);
        Assert.That(dictionary.ContainsKey(2), Is.False);
        Assert.That(dictionary.Count, Is.EqualTo(2));
        
        var exceptionThrown = false;
        try
        {
            dictionary.Remove(4);
        }
        catch (KeyNotFoundException)
        {
            exceptionThrown = true;
        }
        Assert.That(exceptionThrown, Is.True);
    }

    
}
