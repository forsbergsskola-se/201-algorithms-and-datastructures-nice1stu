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


            Assert.IsTrue(tree.Search(10));


        }
    }
}