namespace TurboCollections.Test;

public class TurboLinkedStackTests
{
        [Test]
        public void PushTest()
        {
                var stack = new TurboLinkedStack<int>();
                
                stack.Push(1);
                stack.Push(5);
                stack.Push(13);
                
                Assert.AreEqual(13, stack.LastNode.Value);
                Assert.AreEqual(5, stack.LastNode.Previous.Value);
                Assert.AreEqual(1, stack.LastNode.Previous.Previous.Value);
        }
        
        [Test]
        public void PeekTest()
        {
                var stack = new TurboLinkedStack<int>();
                stack.Push(1);
                stack.Push(5);
                stack.Push(13);

                var result = stack.Peek();

                Assert.AreEqual(13, result);
        }
        
        [Test]
        public void PopTest()
        {
                var stack = new TurboLinkedStack<int>();
                stack.Push(1);
                stack.Push(5);
                stack.Push(13);

                var result = stack.Pop();

                Assert.AreEqual(13, result);
                Assert.AreEqual(5, stack.Peek());
        }
        
        [Test]
        public void ClearTest()
        {
                var stack = new TurboLinkedStack<int>();
                stack.Push(1);
                stack.Push(5);
                stack.Push(13);
                
                stack.Clear();
                
                Assert.IsNull(stack.LastNode);
        }
        
        [Test]
        public void CountTest()
        {
                var stack = new TurboLinkedStack<int>();
                stack.Push(1);
                stack.Push(5);
                stack.Push(13);
                
                var count = stack.Count;
                
                Assert.AreEqual(3, count);
                
                stack.Pop();
                count = stack.Count;
                
                Assert.AreEqual(2, count);
        }
        
        [Test]
        public void EnumeratorTest()
        {
                var stack = new TurboLinkedStack<int>();
                stack.Push(1);
                stack.Push(5);
                stack.Push(13);

                var enumerator = stack.GetEnumerator();
                var result = new List<int>();
                while (enumerator.MoveNext())
                {
                        result.Add(enumerator.Current);
                }

                Assert.AreEqual(new[] { 13, 5, 1 }, result.ToArray());
        }


}
