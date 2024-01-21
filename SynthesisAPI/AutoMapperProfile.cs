namespace SynthesisAPI;
using AutoMapper;
using SynthesisAPI.Dtos;
using SynthesisAPI.Models;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile(){
        CreateMap<Monster, GetMonsterDto>();
        CreateMap<Monster, CreateMonsterDto>();
        CreateMap<Monster, UpdateMonsterDto>();
    }
}