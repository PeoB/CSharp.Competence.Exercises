using System;
using System.Threading.Tasks;
using Extensions.Code;
using NUnit.Framework;

namespace Extensions.Tests
{
    public class TaskExceptionTests
    {
        private int _x = 0;
        private Exception _exception;
        private int _result;

        [TestFixtureSetUp]
        public void SetUp()
        {
            var task = Task.Run(() => 1 / _x).Catch<int, DivideByZeroException>(123, exception => _exception = exception);
            _result = task.Result;
        }

        [Test]
        public void It_should_call_the_callback_with_the_thrown_exception()
        {
            Assert.IsNotNull(_exception);
        }
        
        [Test]
        public void It_should_return_the_default_value()
        {
            Assert.AreEqual(123, _result);            
        }
    }
}