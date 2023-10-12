using Clinical.Application.UseCase.Commons.Bases;
using MediatR;

namespace Clinical.Application.UseCase.UseCases.Exams.Commands.UpdateCommand
{
    public class UpdateExamCommand : IRequest<BaseResponse<bool>>
    {
        public int ExamId { get; set; }
        public string? Name { get; set; }
        public int? AnalysisId { get; set; }
    }
}