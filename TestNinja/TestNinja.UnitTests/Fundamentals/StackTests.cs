using System.Collections;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_ArgIsNull_ThrowArgumentNullException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }
        
        [Test]
        public void Push_ObjectAdded_ReturnCountOne()
        {
            var stack = new Stack<string>();
            
            stack.Push("a");
            
            Assert.That(stack.Count, Is.EqualTo(1));
        }
        
        [Test]
        public void Push_EmptyStack_ReturnCountZero()
        {
            var stack = new Stack<string>();
            
            Assert.That(stack.Count, Is.EqualTo(0));
        }
        
        [Test]
        public void Pop_EmptyStack_ReturnThrowInvalidOperationException()
        {
        
            var stack = new Stack<string>();

            Assert.That(() => stack.Pop(),
                Throws.InvalidOperationException);
        }
        
        [Test]
        public void Pop_StackWithAFewObjects_ReturnObjectOnTheTop()
        {
        
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Pop();

            Assert.That(result, Is.EqualTo("c"));
            Assert.That(stack.Count, Is.EqualTo(2));
        }
        
        [Test]
        public void Peek_EmptyStack_ReturnThrowInvalidOperationException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Peek(),
                Throws.InvalidOperationException);
        }
        
        [Test]
        public void Peek_StackWithObjects_ReturnObjectOnTopOfTheStack()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Peek();
            
            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Peek_StackWithObjects_DoesNotRemoveTheObjectOnTopOfTheStack()
        {   
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            stack.Peek();
            
            Assert.That(stack.Count, Is.EqualTo(3));
        }
    }
}