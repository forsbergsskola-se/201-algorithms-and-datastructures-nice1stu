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
                stack.Push(5);
                stack.Push(13);

                // Assert
                Assert.AreEqual(13, stack.LastNode.Value);
                Assert.AreEqual(5, stack.LastNode.Previous.Value);
                Assert.AreEqual(1, stack.LastNode.Previous.Previous.Value);
        }
        
        [Test]
        public void PeekTest() {
                // Arrange
                var stack = new TurboLinkedStack<int>();
                stack.Push(1);
                stack.Push(5);
                stack.Push(13);

                // Act
                var result = stack.Peek();

                // Assert
                Assert.AreEqual(13, result);
        }
        
        [Test]
        public void PopTest() {
                // Arrange
                var stack = new TurboLinkedStack<int>();
                stack.Push(1);
                stack.Push(5);
                stack.Push(13);

                // Act
                var result = stack.Pop();

                // Assert
                Assert.AreEqual(13, result);
                Assert.AreEqual(5, stack.Peek());
        }

        
        
}
