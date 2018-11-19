using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Xunit;
using Moq;
using System;
using System.Collections.Generic;

namespace talks
{
    public class TalksControllerTests
    {

        [Fact]        
        private void getTalksTest()
        {
            // Arrange.
            var dummyTalks = new List<Talk> {
                new Talk(1, "dummyTitle", "dummyTalker", new DateTime()),
                new Talk(2, "dummyTitle2", "dummyTalker2", new DateTime())
            };
            var mockTalksService = new Mock<ITalksService>();
            mockTalksService.Setup(serv => serv.Get()).Returns(dummyTalks);    

            var sut = new TalksController(mockTalksService.Object);

            // Act.
            var actual = sut.Get().Value.First().Title;

            // Assert.
            Assert.Equal(dummyTalks.First().Title, actual);
        }

    }
}
