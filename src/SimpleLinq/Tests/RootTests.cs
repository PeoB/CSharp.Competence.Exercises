using NUnit.Framework;
using SimpleLinq.Code;

namespace SimpleLinq.Tests
{
    public class When_called_with_a_series_of_decorators
    {
        private readonly RootFactory _underTest=new RootFactory();
        private Root _result;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _result=_underTest.BuildRootUsing(
                root => root.WithTitle("hello world"),
                root => root.WithTitle(root.Title.ToUpper()));
        }
        [Test]
        public void It_should_have_applied_all_decorators()
        {
            Assert.AreEqual("HELLO WORLD",_result.Title);
        } 
    }
}