using Clinical.Application.Dtos.Exam;
using Clinical.Application.UseCase.Commons.Bases;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinical.Application.UseCase.UseCases.Exams.Queries
{
    public class GetAllExamQuery:IRequest<BaseResponse<IEnumerable<GetAllExamResponseDto>>>
    {

    }
}
