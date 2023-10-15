using Clinical.Application.UseCase.Commons.Bases;
using MediatR;

namespace Clinical.Application.UseCase.UseCases.Exams.Commands.ChangeStateCommand
{
    public class ChangeStateExamCommand : IRequest<BaseResponse<bool>>
    {
        public int ExamId { get; set; }
        public int State { get; set; }
    }
}
