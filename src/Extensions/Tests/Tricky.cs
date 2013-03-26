using System;
using System.Linq;
using NUnit.Framework;

namespace Extensions.Tests
{
    public class Tricky
    {
        private Exception _exception;
        private char _result;

        [TestFixtureSetUp]
        public void SetUp()
        {
            //We create the functional stuff here due to how dynamic works, you can move them if you change from dynamic to string
            Func<string, char> func = s => s.First(c => c == 'd');
            Action<Exception> setException = e => _exception = e;
            dynamic str = "abc";
            _result = str
                .Try(func) //Try to do this
                .Catch<ArgumentNullException>(' ', setException)
                .Catch<Exception>('☺', setException) //Catch one or more exceptions and return the default value on exception
                .Finally();//Return the resulting value
        }
        [Test]
        public void It_should_return_the_default_value()
        {
            Assert.AreEqual('☺', _result);
        }
        [Test]
        public void It_should_have_set_the_exception()
        {
            Assert.IsInstanceOf<InvalidOperationException>(_exception);
        }
    }
}