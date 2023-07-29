using Clinical.Application.Interface.Repositories;
using Clinical.Application.Interface.UnitOfWork;
using Clinical.Domain.Entities;

namespace Clinical.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        public IGenericRepository<Analysis> Analisis { get; }

        public UnitOfWork(IGenericRepository<Analysis> analisis)
        {
            Analisis = analisis;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
