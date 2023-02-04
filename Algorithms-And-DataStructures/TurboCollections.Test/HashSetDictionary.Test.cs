using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace DictionaryTests
{
    [TestFixture]
    public class DictionaryTests
    {
        [Test]
        public void TestAddMethod()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            // Test adding an element to the dictionary
            dictionary.Add(1, "One");
        	Assert.That(dictionary.ContainsKey(1), Is.True);
        	Assert.That(dictionary[1], Is.EqualTo("one"));

            // Test adding multiple elements to the dictionary
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");
        	Assert.That(dictionary.ContainsKey(2), Is.True);
        	Assert.That(dictionary[2], Is.EqualTo("two"));
        	Assert.That(dictionary.ContainsKey(3), Is.True);
        	Assert.That(dictionary[3], Is.EqualTo("three"));

            // Test adding an element with a key that already exists in the dictionary
            Assert.That(() => dictionary.Add(3, "another three"), Throws.Exception);
        }

        [Test]
        public void TestRemoveMethod()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");

            // Test removing an element that exists in the dictionary
            dictionary.Remove(2);
        	Assert.That(dictionary.ContainsKey(2), Is.False);
        	Assert.That(dictionary.Count, Is.EqualTo(2));

            // Test removing an element that does not exist in the dictionary
            Assert.That(() => dictionary.Remove(4), Throws.Exception);
        }

        [Test]
        public void TestCountProperty()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            // Test counting elements in an empty dictionary
            Assert.That(dictionary.Count, Is.EqualTo(0));

            // Test counting elements in a non-empty dictionary
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");
            Assert.That(dictionary.Count, Is.EqualTo(3));
        }

        [Test]
        public void TestClearMethod()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");

            // Test clearing elements in the dictionary
            dictionary.Clear();
            Assert.That(dictionary.Count, Is.EqualTo(0));
        }
    }
}