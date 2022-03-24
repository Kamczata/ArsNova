using ArsNova.Model;
using ArsNova.Model.Artowork;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArsNova.Configuration.Profiles
{
    public class ArtworkProfile: Profile
    {
        public ArtworkProfile()
        {
            CreateMap<Artwork, ArtworkDto>()
                .ForMember(x => x.Techniques, opt => opt
                .MapFrom(y => y.TechniquesArtwork.Select(z => z.Technique).ToList()))
                .ReverseMap();
            CreateMap<Artwork, CreateArtworkDto>().ReverseMap();
            CreateMap<Artwork, UpdateArtworkDto>().ReverseMap();
        }
    }
}
