using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wss.Cqrs;

namespace Wss.People
{
    public partial class InMemoryPeopleRepository
    {
        private IEnumerable<Person> GetPeople(string filter) => People.Where(p => p.FirstName.Contains(filter) || p.SecondName.Contains(filter));
        private Person GetPerson(string firstName, string secondName) => People.Where(p => p.FirstName.Equals(firstName) || p.SecondName.Equals(secondName)).FirstOrDefault();

        #region IPeopleQuery

        IEnumerable<Person> IQuery<Person>.GetAll() => People;

        IEnumerable<Person> IPeopleQuery.GetMatchingPeople(string filter) => GetPeople(filter);

        Person IPeopleQuery.GetPerson(string name)
        {
            string[] elements = name.Trim().Split(' ');
            return GetPerson(elements[0], elements[1]);
        }

        Person IPeopleQuery.GetPerson(string firstName, string secondName) => GetPerson(firstName, secondName);

        #endregion
    }
}
