﻿using Clinical.Application.UseCase.Commons.Bases;
using MediatR;

namespace Clinical.Application.UseCase.UseCases.Analysis.Commands.DeleteCommand
{
    public class DeleteAnalysisCommand : IRequest<BaseResponse<bool>>
    {
        public int AnalysisId { get; set; }
    }
}
