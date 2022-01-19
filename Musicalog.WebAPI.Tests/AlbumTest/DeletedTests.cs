using AutoFixture;
using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.DBClasses;
using System.Threading.Tasks;
using Xunit;
using Autofac.Extras.Moq;
using Business.Abstract;
using Moq;
using Entities.DTOClasses.ReturnResultsEntities;
using Musicalog.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Musicalog.WebAPI.Tests.AlbumTest
{
    public class DeleteTests
    {
        private readonly IFixture _fixture;
        public DeleteTests()
        {
            _fixture = new Fixture();
        }

        [Theory, AutoData]
        public async Task Delete_WhenSucces_ShouldReturnOkResult(Album album)
        {
            using var mock = AutoMock.GetStrict();
            var deletedResultObject = _fixture.Build<Result>().With(d => d.Success, true).Create();
            mock.Mock<IAlbumService>().Setup(d => d.Delete(album)).ReturnsAsync(deletedResultObject);

            var albumController = mock.Create<AlbumsController>();
            var result = await albumController.Delete(album);

            var returnObject = result as OkObjectResult;

            Assert.Equal((int)HttpStatusCode.OK, returnObject?.StatusCode);

            mock.Mock<IAlbumService>().Verify(x => x.Delete(album), Times.Once);

        }      

        [Theory, AutoData]
        public async Task Delete_WhenFail_ShouldReturnBadRequest(Album album)
        {
            using var mock = AutoMock.GetStrict();
            var deletedResultObject = _fixture.Build<Result>().With(d => d.Success, false).Create();
            mock.Mock<IAlbumService>().Setup(d => d.Delete(album)).ReturnsAsync(deletedResultObject);

            var albumController = mock.Create<AlbumsController>();
            var result = await albumController.Delete(album);

            var returnObject = result as BadRequestObjectResult;

            Assert.Equal((int)HttpStatusCode.BadRequest, returnObject?.StatusCode);

            mock.Mock<IAlbumService>().Verify(x => x.Delete(album), Times.Once);

        }
    }
}
