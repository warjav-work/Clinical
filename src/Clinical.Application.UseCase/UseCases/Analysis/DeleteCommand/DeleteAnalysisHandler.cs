using AutoMapper;
using Clinical.Application.Interface.Repositories;
using Clinical.Application.UseCase.Commons.Bases;
using MediatR;

namespace Clinical.Application.UseCase.UseCases.Analysis.DeleteCommand
{
    public class DeleteAnalysisHandler : IRequestHandler<DeleteAnalysisCommand, BaseResponse<bool>>
    {
        private readonly IAnalysisRepository _analysisRepository;
        private readonly IMapper _mapper;

        public DeleteAnalysisHandler(IAnalysisRepository analysisRepository, IMapper mapper)
        {
            _analysisRepository = analysisRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<bool>> Handle(DeleteAnalysisCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<bool>();

            try
            {

                response.Data = await _analysisRepository.AnalysisRemove(request.AnalysisId);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Se eliminó correctamente.";
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
