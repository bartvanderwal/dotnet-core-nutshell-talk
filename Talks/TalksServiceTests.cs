using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace talks
{
    public class TalksServiceTests
    {
        private TalksService sut;

        public TalksServiceTests() {
            sut = new TalksService();
        }

        [Fact]        
        private void getTalksTest()
        {
            // Arrange.
            var expected = "Kotlin";

            // Act.
            var actual = sut.Get().First().Title;

            // Assert.
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void findByTalkTitleOrTalkernameTest() {
            // Arrange.

            // Act.
            sut.findByTalkTitleOrTalkername("Bart");

            // Assert.
        }

    }
}
