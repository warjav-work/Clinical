using Clinical.Application.Dtos.Exam;

namespace Clinical.Application.Interface.Repositories
{
    public interface IExamRepository
    {
        Task<IEnumerable<GetAllExamResponseDto>> GetAllExam(string storedprocedure);
    }
}
