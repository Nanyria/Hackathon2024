using HackathonBackend.Models;

namespace HackathonBackend.Repositories
{
    public interface IEnergyRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Create(T entity);
        Task<T> Update(int id, T entity);
        Task Delete(int id);
    }
}
