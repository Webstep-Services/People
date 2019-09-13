using Microsoft.AspNetCore.Mvc;

namespace Wss.People.Rest.Controllers
{
    public partial class PeopleController : ControllerBase
    {
        public IPeopleCommand PeopleCommand => Repository;

        [HttpPost]
        public void AddPerson([FromBody] string value)
        {
            PeopleCommand.Add(value);
        }

        // PUT: api/People/5
        [HttpPut("{id}")]
        public void UpdatePerson(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeletePerson(int id)
        {
        }
    }
}
