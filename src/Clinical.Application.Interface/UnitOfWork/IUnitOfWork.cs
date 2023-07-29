using Clinical.Application.Interface.Repositories;
using Clinical.Domain.Entities;

namespace Clinical.Application.Interface.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Analysis> Analisis { get; }

    }
}
