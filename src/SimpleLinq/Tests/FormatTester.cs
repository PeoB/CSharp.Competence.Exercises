using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using _ = SimpleLinq.Code.HelperFunctions;
namespace SimpleLinq.Tests
{
    public class FormatTester
    {
        private string[] _result;

        [TestFixtureSetUp]
        public void SetUp()
        {
            var arr = new[]
                {
                    new {Age = 23, FirstName = "Example", LastName = "Person"},
                    new {Age = 89, FirstName = "Other", LastName = "Dude"}
                };
            _result = arr.Select(_.Format("{:index}) {FirstName} {LastName} is {Age} years old!")).ToArray();
        }
        [Test]
        public void It_should_return_the_formated_strings()
        {
            Assert.AreEqual("0) Example Person is 23 years old!",_result[0]);
            Assert.AreEqual("1) Example Person is 89 years old!",_result[1]);
        }
    }
}