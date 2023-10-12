using Clinical.Application.Dtos.Exam;
using Clinical.Application.UseCase.Commons.Bases;
using MediatR;

namespace Clinical.Application.UseCase.UseCases.Exams.Queries.GetByIdQuery
{
    public class GetExamByIdQuery : IRequest<BaseResponse<GetExamByIdResponseDto>>
    {
        public int ExamId { get; set; }
    }
}
