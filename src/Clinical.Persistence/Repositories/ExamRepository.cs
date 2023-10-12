using Clinical.Application.Dtos.Exam;
using Clinical.Application.Interface.Repositories;
using Clinical.Domain.Entities;
using Clinical.Persistence.Context;
using Dapper;
using System.Data;

namespace Clinical.Persistence.Repositories
{
    public class ExamRepository : GenericRepository<Exam> , IExamRepository
    {
        private readonly ApplicationDbContext _context;
        public ExamRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GetAllExamResponseDto>> GetAllExam(string storedprocedure)
        {
            using var conecction = _context.CreateConnection;
            var exams = await conecction.QueryAsync<GetAllExamResponseDto>(storedprocedure, commandType: CommandType.StoredProcedure);
            return exams;
        }
    }
}
