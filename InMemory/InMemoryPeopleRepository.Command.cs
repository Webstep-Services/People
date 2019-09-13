using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wss.Cqrs;

namespace Wss.People
{
    public partial class InMemoryPeopleRepository : IPeopleCommand
    {
        void IPeopleCommand.Add(string name)
        {
        }

        void IPeopleCommand.Add(string firstName, string secondName)
        {
        }

        void ICommand<Person>.Add(Person instance)
        {
        }

        void IPeopleCommand.Update(int id, string value)
        {
            throw new NotImplementedException();
        }

        void ICommand<Person>.Update(Person instance)
        {
            throw new NotImplementedException();
        }

        void ICommand<Person>.Delete(Person instance)
        {
        }


    }
}
