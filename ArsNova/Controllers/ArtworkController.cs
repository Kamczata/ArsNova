using AutoMapper;
using DataManipulation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArsNova.Model.Artowork;
using DataManipulation.Configuration.Paging;
using Domain;

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
        public IActionResult GetAllArtworks([FromQuery] PagingOptions options)
        {
            var artworks = _uow.Artworks.GetAll(null, null, new List<string>() { "Artist", "Category", "TechniquesArtwork" }, pagingOptions: options);
            var artworksDto = _mapper.Map<List<ArtworkDto>>(artworks);

            return Ok(artworksDto);
        }

        [HttpGet("{id}")]
        [ActionName("Artwork")]
        public IActionResult GetArtwork(int id)
        {
            var artwork = _uow.Artworks.Get(x => x.Id == id, new List<string>() { "Artist", "Category", "TechniquesArtwork" });
            var artworkDto = _mapper.Map<ArtworkDto>(artwork);

            return Ok(artworkDto);
        }

        [HttpGet("{id}")]
        [ActionName("Artwork/Category")]
        public IActionResult GetArtworksFromCategory(int id, [FromQuery] PagingOptions options)
        {
            
            var category = _uow.Categories.Get(x => x.Id == id);
            var artworks = _uow.Artworks.GetAll(x => x.CategoryId == category.Id, null, new List<string>() { "Artist", "Category", "TechniquesArtwork" }, pagingOptions: options);
            var artworksDto = _mapper.Map<List<Artwork>>(artworks);
           
            return Ok(artworksDto);
        }
    }
}
