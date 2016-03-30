using System.Linq;

namespace NFeTaxesCalculator.Domain.Repositories
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> List();
    }
}