using NUnit.Framework;

namespace TurboCollections.Tests
{
    public class SearchBinaryTests
    {
        private SearchBinary _searchBinary;

        [SetUp]
        public void SetUp()
        {
            _searchBinary = new SearchBinary();
        }

        [Test]
        public void TestBinarySearchKeyFound()
        {
            int[] arr = new int[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            int key = 16;
            int expectedIndex = 4;
            int actualIndex = _searchBinary.BinarySearchDisplay(arr, key);

            Assert.That(actualIndex, Is.EqualTo(expectedIndex));
        }

        [Test]
        public void TestBinarySearchKeyNotFound()
        {
            int[] arr = new int[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            int key = 101;
            int expectedIndex = -1; //throw exception
            int actualIndex = _searchBinary.BinarySearchDisplay(arr, key);

            Assert.That(actualIndex, Is.EqualTo(expectedIndex));
        }

        [Test]
        public void TestBinarySearchEmptyArray()
        {
            int[] arr = new int[] {};
            int key = 11;
            int expectedIndex = -1;
            int actualIndex = _searchBinary.BinarySearchDisplay(arr, key);

            Assert.That(actualIndex, Is.EqualTo(expectedIndex));
        }
    }
}