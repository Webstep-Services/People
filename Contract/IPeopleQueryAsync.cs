using System.Collections.Generic;
using System.Threading.Tasks;
using Wss.Cqrs;

namespace Wss.People
{
    public interface IPeopleQueryAsync : IQueryAsync<Person>
    {
        Task<IEnumerable<Person>> GetAllAsync(bool includePhoneNumbers);

        Task<IEnumerable<Person>> GetMatchingPeopleAsync(string filter);

        Task<Person> GetPersonAsync(string name);

        Task<Person> GetPersonAsync(string firstName, string secondName);
    }
}