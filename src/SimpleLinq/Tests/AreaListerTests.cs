using System.Linq;
using NUnit.Framework;

namespace SimpleLinq.Tests
{
    public class When_areas_contains_parts
    {
        private static readonly Area _area = new Area { Parts = Enumerable.Repeat(new Part(), 3) };

        private readonly AreaListerVM _underTest = new AreaListerVM { Areas = new[] { _area, _area, _area }, Index = 3 };

        [Test]
        public void ItShouldListAllParts()
        {
            Assert.AreEqual(9, _underTest.Parts.Count());
        }
    }


    public class When_index_is_higher_or_equal_to_number_of_parts_in_first_area
    {
        private static readonly Area _expected = new Area { Parts = Enumerable.Repeat(new Part(), 3) };

        private readonly AreaListerVM _underTest = new AreaListerVM
            {
                Areas = new[]
                    {
                        new Area { Parts = Enumerable.Repeat(new Part(), 3) }, 
                        _expected
                    }, Index = 3
            };

        [Test]
        public void It_should_have_the_second_area_selected()
        {
            Assert.AreEqual(_expected, _underTest.CurrentArea);
        }
    }

    public class When_areas_is_empty
    {
        private readonly AreaListerVM _underTest = new AreaListerVM { Areas = Enumerable.Empty<Area>() };
        [Test]
        public void It_should_return_empty_collection_for_parts()
        {
            Assert.IsEmpty(_underTest.Parts);
        }

        [Test]
        public void It_should_return_null_for_current_area()
        {
            Assert.IsNull(_underTest.CurrentArea);
        }
    }

    public class When_area_is_selected_by_area_index
    {

        private readonly AreaListerVM _underTest=new AreaListerVM{Areas = new []
            {
                new Area { Parts = Enumerable.Repeat(new Part(), 3) },
                new Area { Parts = Enumerable.Repeat(new Part(), 3) }
            }};

        [TestFixtureSetUp]
        public void SetUp()
        {
            _underTest.JumpToArea(1);
        }

        [Test]
        public void It_should_have_the_index_set_to_the_first_part_of_that_area()
        {
            Assert.AreEqual(3,_underTest.Index);
        }
    }
}