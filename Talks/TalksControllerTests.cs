using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace talks.Controllers
{
    public class TalksControllerTests
    {

        [Fact]        
        private void getTalksTest()
        {
            // Arrange.
            var sut = new TalksController();
            var expected = "Kotlin";

            // Act.
            var actual = sut.Get().Value.First().Title;

            // Assert.
            Assert.Equal(expected, actual);
        }

        [Fact]
        private void testToBedrag() {
            // Arrange.
            var sut = 42;
            var expected = "€ 42,-";

            // Act.
            var actual = sut.toBedrag();

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
