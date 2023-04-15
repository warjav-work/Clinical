using AutoMapper;
using Clinical.Application.Dtos.Analysis.Response;
using Clinical.Domain.Entities;

namespace Clinical.Application.UseCase.Mappings
{
    public class AnalysisMappingProfile : Profile
    {
        public AnalysisMappingProfile()
        {
            CreateMap<Analysis, GetAllAnalysisResponseDto>()
                .ForMember(x => x.StateAnalysis, x => x.MapFrom(y => y.State == 1 ? "Activo" : "Inactivo"))
                .ReverseMap();
        }
    }
}
