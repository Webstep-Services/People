using System.Collections.Generic;

namespace Wss.Cqrs
{
    public interface IQuery<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
