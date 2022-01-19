using Business.Abstract;
using Business.AutoFac.Aspects.Validation;
using Business.FluentValidation;
using Entities.DBClasses;
using Entities.DTOClasses.ReturnResultsEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Musicalog.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        private readonly IAlbumService _albumService;
        public AlbumsController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        /// <summary>
        /// To List All Albums Records
        /// </summary>
        /// <returns></returns>
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _albumService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        /// <summary>
        /// To Add a New Album Record
        /// </summary>
        /// <param name="album"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public async Task<IActionResult> Add(Album album)
        {
            var result = await _albumService.Add(album);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        /// <summary>
        /// To Update Album Record 
        /// </summary>
        /// <param name="album"></param>
        /// <returns></returns>
        [HttpPut("update")]
        public async Task<IActionResult> Update(Album album)
        {
            var result = await _albumService.Update(album);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        /// <summary>
        /// Get Album List By Album Title and Album Artist Name
        /// </summary>
        /// <param name="title"></param>
        /// <param name="artistName"></param>
        /// <returns></returns>
        [HttpGet("albumsbyfilter")]
        public async Task<IActionResult> GetAlbumListByTitleAndArtistName(string title, string artistName)
        {
            var result = await _albumService.GetAlbumListByTitleAndArtistName(title, artistName);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        /// <summary>
        /// To Delete Album Item
        /// </summary>
        /// <param name="album"></param>
        /// <returns></returns>
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Album album)
        {
            var result = await _albumService.Delete(album);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
