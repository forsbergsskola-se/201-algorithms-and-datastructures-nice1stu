using NUnit.Framework;

namespace TurboCollections.Tests
{
    [TestFixture]
    public class TurboBstTests
    {
        [Test]
        public void Insert_AddsNodeToTree()
        {
            TurboBST tree = new TurboBST();
            tree.Insert(10);
            tree.Insert(20);
            tree.Insert(30);
            tree.Insert(40);
            tree.Insert(50);


            Assert.That(tree.Search(10), Is.True);
            Assert.That(tree.Search(20), Is.True);
            Assert.That(tree.Search(30), Is.True);
            Assert.That(tree.Search(40), Is.True);
            Assert.That(tree.Search(50), Is.True);
        }
        
        [Test]
        public void Delete_RemovesNodeFromTree()
        {
            TurboBST tree = new TurboBST();
            tree.Insert(10);
            tree.Insert(20);
            tree.Insert(30);
            tree.Insert(40);
            tree.Insert(50);

            tree.Delete(20);
            
            Assert.That(tree.Search(10), Is.True);
            Assert.That(tree.Search(20), Is.False);
            Assert.That(tree.Search(30), Is.True);
            Assert.That(tree.Search(40), Is.True);
            Assert.That(tree.Search(50), Is.True);
        }
        
        [Test]
        public void Search_ReturnsTrueForExistingNode()
        {
            TurboBST tree = new TurboBST();
            tree.Insert(10);
            tree.Insert(20);
            tree.Insert(30);
            tree.Insert(40);
            tree.Insert(50);
            
            Assert.That(tree.Search(10), Is.True);
            Assert.That(tree.Search(30), Is.True);
            Assert.That(tree.Search(50), Is.True);
            Assert.That(tree.Search(60), Is.False);
            
        }
    }
}