using Clinical.Application.UseCase.Commons.Bases;
using MediatR;

namespace Clinical.Application.UseCase.UseCases.Exams.Commands.DeleteCommand
{
    public class DeleteExamCommand : IRequest<BaseResponse<bool>>
    {
        public int ExamId { get; set; }
    }
}
