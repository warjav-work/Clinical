using AutoMapper;
using Clinical.Application.Interface.UnitOfWork;
using Clinical.Application.UseCase.Commons.Bases;
using Clinical.Application.UseCase.UseCases.Analysis.Commands.ChangeStateCommand;
using Clinical.Domain.Entities;
using Clinical.Utilities.Constants;
using Clinical.Utilities.HelperExtensions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinical.Application.UseCase.UseCases.Exams.Commands.ChangeStateCommand
{
    internal class ChangeStateExamHandler : IRequestHandler<ChangeStateExamCommand, BaseResponse<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ChangeStateExamHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponse<bool>> Handle(ChangeStateExamCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<bool>();

            try
            {
                var exam = _mapper.Map<Exam>(request);
                var parameters = exam.GetPropertiesWithValues();
                response.Data = await _unitOfWork.Exams.ExecAsync(SP.upsExamChangeState, parameters);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = GlobalMessages.MESSAGE_UPDATE_STATE;
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
