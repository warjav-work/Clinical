using Clinical.Application.Interface.Repositories;
using Clinical.Application.Interface.UnitOfWork;
using Clinical.Domain.Entities;
using Clinical.Persistence.Context;
using Clinical.Persistence.Repositories;

namespace Clinical.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IGenericRepository<Analysis> Analisis { get; }
        public IExamRepository Exams { get; }

        public UnitOfWork(ApplicationDbContext context, IGenericRepository<Analysis> analisis)
        {
            _context = context;
            Analisis = analisis;
            Exams = new ExamRepository(_context);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
