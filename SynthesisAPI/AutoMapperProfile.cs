namespace SynthesisAPI;
using AutoMapper;
using SynthesisAPI.Dtos;
using SynthesisAPI.Models;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile(){
        CreateMap<GetMonsterDto, Monster>();
        CreateMap<Monster, CreateMonsterDto>();
        CreateMap<CreateMonsterDto, Monster>();
        CreateMap<Monster, UpdateMonsterDto>();
    }
}