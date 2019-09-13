using System.Collections.Generic;
using Wss.Cqrs;

namespace Wss.People
{
    public interface IPeopleQuery : IQuery<Person>
    {
        IEnumerable<Person> GetMatchingPeople(string filter);

        Person GetPerson(string name);

        Person GetPerson(string firstName, string secondName);
    }
}