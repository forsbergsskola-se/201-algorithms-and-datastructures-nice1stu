[TestFixture]
public class DictionaryTests
{
    [Test]
    public void TestAddMethod()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        // Test adding a new key-value pair
        dictionary.Add(1, "One");
        Assert.That(dictionary.ContainsKey(1), Is.True);
        Assert.That(dictionary[1], Is.EqualTo("One"));
        Assert.That(dictionary.Count, Is.EqualTo(1));

        // Test adding a key-value pair with an existing key
        Assert.Throws<ArgumentException>(() => dictionary.Add(1, "Uno"));
    }

    [Test]
    public void TestContainsKeyMethod()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "One");
        dictionary.Add(2, "Two");

        // Test checking for a key that exists
        Assert.That(dictionary.ContainsKey(1), Is.True);

        // Test checking for a key that does not exist
        Assert.That(dictionary.ContainsKey(3), Is.False);
    }

    [Test]
    public void TestIndexerGet()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "One");
        dictionary.Add(2, "Two");

        // Test retrieving a value for a key that exists
        Assert.That(dictionary[1], Is.EqualTo("One"));

        // Test retrieving a value for a key that does not exist
        Assert.Throws<KeyNotFoundException>(() => dictionary[2]);
    }

    [Test]
    public void TestIndexerSet()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "One");

        // Test replacing a value for a key that exists
        dictionary[1] = "Uno";
        Assert.That(dictionary[1], Is.EqualTo("Uno"));

        // Test adding a value for a key that does not exist
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

        // Test removing a key-value pair that exists
        dictionary.Remove(2);
        Assert.That(dictionary.ContainsKey(2), Is.False);
        Assert.That(dictionary.Count, Is.EqualTo(2));

        // Test removing a key-value pair that does not exist
        Assert.Throws<KeyNotFoundException>(() => dictionary.Remove(4));

        // Test adding a key-value pair that does not exist
        dictionary.Add(4, "Four");
        Assert.That(dictionary.ContainsKey(4), Is.True);
        Assert.That(dictionary.Count, Is.EqualTo(3));

        // Test adding a key-value pair that already exists
        Assert.Throws<ArgumentException>(() => dictionary.Add(1, "One"));

        // Test using the ContainsKey method to check if a key exists
        Assert.That(dictionary.ContainsKey(5), Is.False);
        Assert.That(dictionary.ContainsKey(1), Is.True);

        // Test using the indexer to get a value for a key
        string value = dictionary[3];
        Assert.That(value, Is.EqualTo("Three"));

        // Test using the indexer to get a value for a key that does not exist
        Assert.Throws<KeyNotFoundException>(() => { var v = dictionary[5]; });

        // Test using the indexer to set a value for a key that already exists
        dictionary[3] = "Three New";
        Assert.That(dictionary[3], Is.EqualTo("Three New"));

        // Test using the indexer to set a value for a key that does not exist
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

        // Test removing a key-value pair that exists
        dictionary.Remove(2);
        Assert.That(dictionary.ContainsKey(2), Is.False);
        Assert.That(dictionary.Count, Is.EqualTo(2));

        // Test removing a key-value pair that does not exist
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
