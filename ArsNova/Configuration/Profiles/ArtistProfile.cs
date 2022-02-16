using ArsNova.Model.Artist;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArsNova.Configuration.Profiles
{
    public class ArtistProfile: Profile
    {
        public ArtistProfile()
        {
            CreateMap<Artist, ArtistDto>().ReverseMap();
            CreateMap<Artist, CreateArtistDto>().ReverseMap();
            CreateMap<Artist, UpdateArtistDto>().ReverseMap();
        }
    }
}
