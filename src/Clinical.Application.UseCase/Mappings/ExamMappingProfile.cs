using AutoMapper;
using Clinical.Application.Dtos.Exam;
using Clinical.Domain.Entities;

namespace Clinical.Application.UseCase.Mappings
{
    internal class ExamMappingProfile : Profile
    {
        public ExamMappingProfile()
        {
            CreateMap<Exam, GetExamByIdResponseDto>()
                .ReverseMap();
        }
    }
}
