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
    public class ArtworkController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public ArtworkController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        [HttpGet]
        [ActionName("All")]
        public IActionResult GetAllArtworks()
        {
            var artworks = _uow.Artworks.GetAll();
            var artworksDto = _mapper.Map<List<ArtworkDto>>(artworks);

            return Ok(artworksDto);
        }

        [HttpGet("{id}")]
        [ActionName("Artwork")]
        public IActionResult GetArtwork(int id)
        {
            var artwork = _uow.Artworks.Get(x => x.Id == id);
            var artworkDto = _mapper.Map<ArtworkDto>(artwork);

            return Ok(artworkDto);
        }
    }
}
