using System.Linq;
using Extensions.Code;
using NUnit.Framework;

namespace Extensions.Tests
{
    public class TimesTests
    {
        [Test]
        public void It_should_return_a_list_containing_all_the_indexes()
        {
            var objs = 5.Times(i => new { Index = i });

            Assert.AreEqual(2,objs.ToList()[2].Index);
        }
    }
}