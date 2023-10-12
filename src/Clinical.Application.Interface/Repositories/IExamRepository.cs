using Clinical.Application.Dtos.Exam;
using Clinical.Domain.Entities;

namespace Clinical.Application.Interface.Repositories
{
    public interface IExamRepository :IGenericRepository<Exam>
    {
        Task<IEnumerable<GetAllExamResponseDto>> GetAllExam(string storedprocedure);
    }
}
