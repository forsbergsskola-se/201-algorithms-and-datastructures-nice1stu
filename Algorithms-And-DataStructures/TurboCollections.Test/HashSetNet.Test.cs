using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace HashSetTests
{
    [TestFixture]
    public class HashSetTests
    {
        [Test]
        public void TestAddMethodOneElement()
        {
            HashSet<int> hashSet = new HashSet<int>();

            // Test adding an element to the HashSet
            hashSet.Add(69);
            Assert.That(hashSet.Contains(69), Is.True);
        }

        [Test]
        public void TestAddMethodMultipleElement()
        {
            HashSet<int> hashSet = new HashSet<int>();
            
            hashSet.Add(1);
            hashSet.Add(13);
            Assert.That(hashSet.Contains(1), Is.True);
            Assert.That(hashSet.Contains(13), Is.True);
        }
        
        [Test]
        public void TestAddMethodExistingElement()
        {
            HashSet<int> hashSet = new HashSet<int>();
            
            hashSet.Add(1);
            hashSet.Add(13);
            hashSet.Add(13);
            Assert.That(hashSet.Count, Is.EqualTo(2));
        }
        
        [Test]
        public void TestRemoveMethod()
        {
            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(1);
            hashSet.Add(2);
            hashSet.Add(3);

            // Test removing an element that exists in the HashSet
            hashSet.Remove(2);
            Assert.That(hashSet.Contains(2), Is.False);
            Assert.That(hashSet.Count, Is.EqualTo(2));

            // Test removing an element that does not exist in the HashSet
            hashSet.Remove(4);
            Assert.That(hashSet.Count, Is.EqualTo(2));
        }

        [Test]
        public void TestCountProperty()
        {
            HashSet<int> hashSet = new HashSet<int>();

            // Test counting elements in an empty HashSet
            Assert.That(hashSet.Count, Is.EqualTo(0));

            // Test counting elements in a non-empty HashSet
            hashSet.Add(1);
            hashSet.Add(2);
            hashSet.Add(3);
            Assert.That(hashSet.Count, Is.EqualTo(3));
        }

        [Test]
        public void TestClearMethod()
        {
            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(1);
            hashSet.Add(2);
            hashSet.Add(3);

            // Test clearing elements in the HashSet
            hashSet.Clear();
            Assert.That(hashSet.Count, Is.EqualTo(0));
        }
    }
}