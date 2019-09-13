using System.Collections.Generic;
using System.Threading.Tasks;

namespace Wss.People
{
    public interface IPeopleRepository : IPeopleQuery, IPeopleCommand
    {
    }
}