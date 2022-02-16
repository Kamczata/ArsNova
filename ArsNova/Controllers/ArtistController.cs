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
        public IActionResult GetArtists()
        {
            var artists = _uow.Artists.GetAll();
            var artistsDto = _mapper.Map<List<ArtistDto>>(artists);

            return Ok(artists);
        }

        [HttpGet("{id}")]
        public IActionResult GetArtist(int id)
        {
            var artist = _uow.Artists.Get(x => x.Id == id);
            var artistDto = _mapper.Map<ArtistDto>(artist);

            return Ok(artistDto);
        }
    }
}
