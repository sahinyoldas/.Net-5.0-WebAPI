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
    public class AddTests
    {
        private readonly IFixture _fixture;
        public AddTests()
        {
            _fixture = new Fixture();
        }

        [Theory, AutoData]
        public async Task Add_WhenSucces_ShouldReturnOkResult(Album album)
        {
            using var mock = AutoMock.GetStrict();
            var createdResultObject = _fixture.Build<Result>().With(d => d.Success, true).Create();
            mock.Mock<IAlbumService>().Setup(d => d.Add(album)).ReturnsAsync(createdResultObject);

            var albumController = mock.Create<AlbumsController>();
            var result = await albumController.Add(album);

            var degisken = result as OkObjectResult;

            Assert.Equal((int)HttpStatusCode.OK, degisken?.StatusCode);

            mock.Mock<IAlbumService>().Verify(x => x.Add(album), Times.Once);

        }

        //[Theory, AutoData]
        //public async Task Add_WhenSucces_ShouldReturnOkResultyyy()
        //{
        //    using var mock = AutoMock.GetStrict();
        //    var createdResultObject = _fixture.Build<Result>().With(d => d.Success, true).Create();
        //    var albummmmm = _fixture.Build<Album>().
        //        With(d => d.Title, "olurum sana").
        //        With(d => d.ArtistName, "tarkan").
        //        With(d => d.AlbumType, Entities.Enums.AlbumType.Cd).
        //        Create();
        //    mock.Mock<IAlbumService>().Setup(d => d.Add(albummmmm)).ReturnsAsync(createdResultObject);

        //    var albumController = mock.Create<AlbumsController>();
        //    var result = await albumController.Add(albummmmm);

        //    var degisken = result as OkObjectResult;

        //    Assert.Equal((int)HttpStatusCode.OK, degisken?.StatusCode);

        //    mock.Mock<IAlbumService>().Verify(x => x.Add(albummmmm), Times.Once);

        //}

        [Theory, AutoData]
        public async Task Add_WhenFail_ShouldReturnBadRequest(Album album)
        {
            using var mock = AutoMock.GetStrict();
            var createdResultObject = _fixture.Build<Result>().With(d => d.Success, false).Create();
            mock.Mock<IAlbumService>().Setup(d => d.Add(album)).ReturnsAsync(createdResultObject);

            var albumController = mock.Create<AlbumsController>();
            var result = await albumController.Add(album);

            var degisken = result as BadRequestObjectResult;

            Assert.Equal((int)HttpStatusCode.BadRequest, degisken?.StatusCode);

            mock.Mock<IAlbumService>().Verify(x => x.Add(album), Times.Once);

        }
    }
}
