using Clinical.Application.Interface.UnitOfWork;
using Clinical.Application.UseCase.Commons.Bases;
using Clinical.Utilities.Constants;
using MediatR;

namespace Clinical.Application.UseCase.UseCases.Exams.Commands.DeleteCommand
{
    public class DeleteExamHandler : IRequestHandler<DeleteExamCommand, BaseResponse<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteExamHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseResponse<bool>> Handle(DeleteExamCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<bool>();

            try
            {
                response.Data = await _unitOfWork.Exams.ExecAsync(SP.upsExamRemove, request);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = GlobalMessages.MESSAGE_DELETE;
                }
            }
            catch (Exception ex)
            {

                response.Message = ex.Message;
            }
            return response;
        }
    }
}
