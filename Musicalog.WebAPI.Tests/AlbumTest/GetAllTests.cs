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
    public class GetAllTests
    {
        private readonly IFixture _fixture;
        public GetAllTests()
        {
            _fixture = new Fixture();
        }

        [Theory, AutoData]
        public async Task GetAll_WhenSucces_ShouldReturnOkResult()
        {
            using var mock = AutoMock.GetStrict();
            var listedAlbums = _fixture.Build<DataResult<List<Album>>>().With(d => d.Success, true).Create();
            mock.Mock<IAlbumService>().Setup(d => d.GetAll()).ReturnsAsync(listedAlbums);

            var albumController = mock.Create<AlbumsController>();
            var result = await albumController.GetAll();

            var returnObject = result as OkObjectResult;

            Assert.Equal((int)HttpStatusCode.OK, returnObject?.StatusCode);

            mock.Mock<IAlbumService>().Verify(x => x.GetAll(), Times.Once);

        }

        [Theory, AutoData]
        public async Task GetAll_WhenFail_ShouldReturnBadRequest()
        {
            using var mock = AutoMock.GetStrict();
            var listedAlbums = _fixture.Build<DataResult<List<Album>>>().With(d => d.Success, false).Create();
            mock.Mock<IAlbumService>().Setup(d => d.GetAll()).ReturnsAsync(listedAlbums);

            var albumController = mock.Create<AlbumsController>();
            var result = await albumController.GetAll();

            var returnObject = result as OkObjectResult;

            Assert.Equal((int)HttpStatusCode.OK, returnObject?.StatusCode);

            mock.Mock<IAlbumService>().Verify(x => x.GetAll(), Times.Once);

        }
    }
}
