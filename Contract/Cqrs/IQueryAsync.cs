using System.Collections.Generic;
using System.Threading.Tasks;

namespace Wss.Cqrs
{
    public interface IQueryAsync<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
    }
}