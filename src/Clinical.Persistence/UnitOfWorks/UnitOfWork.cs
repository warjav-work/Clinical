using Clinical.Application.Interface.Repositories;
using Clinical.Application.Interface.UnitOfWork;
using Clinical.Domain.Entities;

namespace Clinical.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        public IGenericRepository<Analysis> Analisis { get; }
        public IExamRepository Exams { get; }

        public UnitOfWork(IGenericRepository<Analysis> analisis, IExamRepository exams)
        {
            Analisis = analisis;
            Exams = exams;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
