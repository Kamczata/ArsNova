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
            var artworks = _uow.Artworks.GetAll(null, null, new List<string>() { "Artist", "TechniquesArtwork" }, pagingOptions: options);
            var artworksDto = _mapper.Map<List<ArtworkDto>>(artworks);

            return Ok(artworksDto);
        }

        [HttpGet("{id}")]
        [ActionName("Artwork")]
        public IActionResult GetArtwork(int id)
        {
            var artwork = _uow.Artworks.Get(x => x.Id == id, new List<string>() { "Artist", "TechniquesArtwork" });
            /*var categoriesIds = _uow.CategoriesArtwork.GetAll(x => x.ArtworkId == id).Select(y => y.CategoryId);
            var artworkCategories = _uow.Categories.GetAll(x => categoriesIds.Contains(x.Id));*/

            /*var techniquesIds = artwork.TechniquesArtwork.Select(x => x.TechniqueId).ToList();
            var artworkTechniques = _uow.Techniques.GetAll(x => techniquesIds.Contains(x.Id));*/

            var artworkDto = _mapper.Map<ArtworkDto>(artwork);
            //artworkDto.Categories = artworkCategories;
            //artworkDto.Techniques = artworkTechniques;

            return Ok(artworkDto);
        }

        [HttpGet("{id}")]
        [ActionName("Artwork/Category")]
        public IActionResult GetArtworksFromCategory(int id, [FromQuery] PagingOptions options)
        {
            
            var category = _uow.Categories.Get(x => x.Id == id);
            //var artworksIds = _uow.CategoriesArtwork.GetAll(x => x.CategoryId == id).Select(y => y.ArtworkId);
            //var artworks = _uow.Artworks.GetAll(x => artworksIds.Contains(x.Id), null, new List<string>() { "Artist" }, pagingOptions: options);
            var artworks = _uow.Artworks.GetAll(null, null, new List<string>() { "Artist" }, pagingOptions: options);
            var artworksDto = _mapper.Map<List<Artwork>>(artworks);
            /*foreach(var artworkDto in artworksDto)
            {
                artworkDto.Categories.Add(category);
            }*/
           
            return Ok(artworksDto);
        }
    }
}
