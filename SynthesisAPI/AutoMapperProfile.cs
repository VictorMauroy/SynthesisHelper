namespace SynthesisAPI;
using AutoMapper;
using SynthesisAPI.Dtos;
using SynthesisAPI.Models;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile(){
        CreateMap<GetMonsterDto, Monster>();

        CreateMap<CreateMonsterDto, Monster>();
        
        CreateMap<UpdateMonsterDto, Monster>();
    }
}