using Dynamic.Code;
using NUnit.Framework;

namespace Dynamic.Tests
{
    public class With_a_single_empty_element
    {
        private dynamic _ = new DynamicXmlGenerator();
        private string _result;

        [SetUp]
        public void SetUp()
        {
            _result = _.html().ToString();
        }
        [Test]
        public void It_should_return_a_string_with_the_element()
        {
            const string expected = "<html></html>";
            Assert.AreEqual(expected, _result);
        }
    }

    public class With_an_element_that_have_internal_tags
    {
        private dynamic _ = new DynamicXmlGenerator();
        private string _result;

        [SetUp]
        public void SetUp()
        {
            _result = _.html(
                    _.head(_.title("Sweet stuff")),
                    _.body(
                        _.h1("Hello world!"))).ToString();
        }

        [Test]
        public void It_should_return_a_string_with_the_tree_structure()
        {
            const string expected = "<html>" +
                                        "<head>" +
                                            "<title>Sweet stuff</title>" +
                                        "</head>" +
                                        "<body>" +
                                            "<h1>Hello world!</h1>" +
                                        "</body>" +
                                    "</html>";

            Assert.AreEqual(expected, _result);
        }
    }

    public class With_elements_that_has_attributes
    {
        private dynamic _ = new DynamicXmlGenerator();
        private string _result;

        [SetUp]
        public void SetUp()
        {
            _result = _.html(
                    _.body(@class: "myClass", style: "font-family:'Comic Sans MS'"),
                    lang: "en")
                 .ToString();
        }

        [Test]
        public void It_should_return_a_string_with_the_attributes_set()
        {
            const string expected = "<html lang=\"en\"><body class=\"myClass\" style=\"font-family:'Comic Sans MS'\"></body></html>";
            Assert.AreEqual(expected, _result);
        }
    }


}