using System.Linq.Expressions;
using Dynamic.Code;
using NUnit.Framework;

namespace Dynamic.Tests
{
    public class DynamicGeneratorTests
    {
        public void It_should_return_the_expected_html()
        {
            dynamic _ = new DynamicXmlGenerator();
            var result =
                _.html(
                    _.head(_.title("Sweet stuff")),
                    _.body(
                        _.h1("Hello world!", style: "font-family:'Comic Sans MS'"))).ToString();

            //Add your own asserts to make sure that you get the expected result
            Assert.AreEqual(
                "<html><head><title>Sweet stuff</title><body><h1 style=\"font-family:'Comic Sans MS'\">Hello world!</h1></body></html>"
                , result);
        }
    }
}