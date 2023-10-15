using AutoMapper;
using Clinical.Application.Dtos.Exam;
using Clinical.Application.UseCase.UseCases.Exams.Commands.ChangeStateCommand;
using Clinical.Application.UseCase.UseCases.Exams.Commands.CreateCommand;
using Clinical.Application.UseCase.UseCases.Exams.Commands.UpdateCommand;
using Clinical.Domain.Entities;

namespace Clinical.Application.UseCase.Mappings
{
    internal class ExamMappingProfile : Profile
    {
        public ExamMappingProfile()
        {
            CreateMap<Exam, GetExamByIdResponseDto>()
                .ReverseMap();
            CreateMap<CreateExamCommand, Exam>();
            CreateMap<UpdateExamCommand, Exam>();
            CreateMap<ChangeStateExamCommand, Exam>();
        }
    }
}
