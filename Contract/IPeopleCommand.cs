using Wss.Cqrs;

namespace Wss.People
{
    public interface IPeopleCommand : ICommand<Person>
    {
        void Add(string name);
        void Add(string firstName, string secondName);
        void Update(int id, string value);
    }
}