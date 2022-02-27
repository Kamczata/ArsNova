using ArsNova.Model.Artist;
using AutoMapper;
using DataManipulation;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArsNova.Controllers
{
    [Route("api/[controller]")]
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

            return Ok(artistsDto);
        }

        [HttpGet("{id}")]
        [ActionName("Artist")]
        public IActionResult GetArtist(int id)
        {
            var artist = _uow.Artists.Get(x => x.Id == id);
            var artistDto = _mapper.Map<ArtistDto>(artist);

            return Ok(artistDto);
        }

        [HttpGet("Category/{id}"), ]
        [ActionName("Category")]
        public IActionResult GetArtistFromCategory(int categoryId)
        {
            var category = _uow.Categories.Get(x => x.Id == categoryId);
            var categoryArtist = _uow.CategoriesArtist.GetAll(x => x.Category == category);
            var artists = _uow.Artists.GetAll(x => x.CategoriesArtist == categoryArtist);
            var artistsDto = _mapper.Map<List<ArtistDto>>(artists);
            return Ok(artistsDto);
        }

        [HttpGet("Location/{id}")]
        [ActionName("Location")]
        public IActionResult GetArtistFromLocation(int id)
        {
            var location = _uow.Locations.Get(x => x.Id == id);
            var artists = _uow.Artists.GetAll(x => x.Location.Equals(location));
            var artistsDto = _mapper.Map<List<ArtistDto>>(artists);
            return Ok(artistsDto);
        }

        [HttpPost]
        [ActionName("Create")]
        public IActionResult CreateArtist(CreateArtistDto artistDto)
        {
            var artist = _mapper.Map<Artist>(artistDto);
            _uow.Artists.Add(artist);
            _uow.Save();
            return NoContent();
        }
    }
}
