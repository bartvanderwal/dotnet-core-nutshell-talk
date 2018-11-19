using Xunit;

namespace talks {

public class ExtensionMethodsTests {


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
