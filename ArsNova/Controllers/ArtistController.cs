using ArsNova.Model.Artist;
using AutoMapper;
using DataManipulation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArsNova.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public ArtistController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        [HttpGet]
        [ActionName("All")]
        public IActionResult GetAllArtists()
        {
            var artists = _uow.Artists.GetAll();
            var artistsDto = _mapper.Map<List<ArtistDto>>(artists);

            return Ok(artists);
        }

        [HttpGet("{id}")]
        [ActionName("Artist")]
        public IActionResult GetArtist(int id)
        {
            var artist = _uow.Artists.Get(x => x.Id == id);
            var artistDto = _mapper.Map<ArtistDto>(artist);

            return Ok(artistDto);
        }

        [HttpGet("{id}")]
        [ActionName("Category")]
        public IActionResult GetArtistFromCategory(int categoryId)
        {
            var category = _uow.Categories.Get(x => x.Id == categoryId);
            var artists = _uow.Artists.GetAll(x => x.Categories.Contains(category));
            var artistsDto = _mapper.Map<List<ArtistDto>>(artists);
            return Ok(artistsDto);
        }

        [HttpGet("{id}")]
        [ActionName("Location")]
        public IActionResult GetArtistFromLocation(int id)
        {
            var location = _uow.Locations.Get(x => x.Id == id);
            var artists = _uow.Artists.GetAll(x => x.Location.Equals(location));
            var artistsDto = _mapper.Map<List<ArtistDto>>(artists);
            return Ok(artistsDto);
        }
    }
}
