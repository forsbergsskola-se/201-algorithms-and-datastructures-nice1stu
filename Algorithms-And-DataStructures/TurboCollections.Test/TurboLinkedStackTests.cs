namespace TurboCollections.Test;

public class TurboLinkedStackTests
{
        [Test]
        public void PushTest()
        {
                // Arrange
                var stack = new TurboLinkedStack<int>();

                // Act
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);

                // Assert
                Assert.AreEqual(3, stack.LastNode.Value);
                Assert.AreEqual(2, stack.LastNode.Previous.Value);
                Assert.AreEqual(1, stack.LastNode.Previous.Previous.Value);
        }
}
