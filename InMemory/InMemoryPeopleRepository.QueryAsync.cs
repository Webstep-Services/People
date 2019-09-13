using System.Collections.Generic;
using System.Threading.Tasks;
using Wss.Cqrs;

namespace Wss.People
{
    public partial class InMemoryPeopleRepository
    {
        #region IPeopleQueryAsync
        async Task<IEnumerable<Person>> IQueryAsync<Person>.GetAllAsync()
        {
            return await Task.Run(() =>
            {
                return People;
            }
            );
        }
        async Task<IEnumerable<Person>> IPeopleQueryAsync.GetAllAsync(bool includePhoneNumber)
        {

            return await Task.Run(() =>
            {
                IEnumerable<Person> people = People;
                IList<Person> clonedPeople = new List<Person>();
                foreach (Person person in People)
                {
                    clonedPeople.Add(new Person(person, includePhoneNumber));
                }
                return clonedPeople;
            }
            );
        }

        async Task<IEnumerable<Person>> IPeopleQueryAsync.GetMatchingPeopleAsync(string filter)
        {
            return await Task.Run(() =>
            {
                return GetPeople(filter);
            }
            );
        }

        async Task<Person> IPeopleQueryAsync.GetPersonAsync(string name)
        {
            return await Task.Run(() =>
            {
                string[] elements = name.Trim().Split(' ');
                return GetPerson(elements[0], elements[1]);
            });
        }

        async Task<Person> IPeopleQueryAsync.GetPersonAsync(string firstName, string secondName)
        {
            return await Task.Run(() =>
            {
                return GetPerson(firstName, secondName);
            });
        }
        #endregion
    }
}
