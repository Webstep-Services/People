using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wss.People.Rest.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System;

namespace Wss.People.Rest.Controllers
{
    public partial class PeopleController : ControllerBase
    {
        public IPeopleQueryAsync PeopleQuery => Repository;

        private async Task<PersonModel[]> GetAllPeopleModel(bool includePhoneNumbers = false)
        {
            var results = await Repository.GetAllAsync(includePhoneNumbers);
            return Mapper.Map<PersonModel[]>(results);
        }
        // GET: api/People
        [HttpGet(Name = "GetAllPeople")]
        public async Task<ActionResult<PersonModel[]>> GetAllPeople(bool includePhoneNumbers = false)
        {
            //CountryProvider countryProvider = new CountryProvider();
            //countryProvider.GetAll();
            return await GetAllPeopleModel(includePhoneNumbers); 
        }

        // GET: api/People/5
        [HttpGet("{id:int}", Name = "GetPerson")]
        public async Task<ActionResult<PersonModel>> GetPerson(int id)
        {
            try
            {
                var model = await GetAllPeopleModel(true);

                if (id < 0 || id >= model.Count())
                {
                    return NotFound();
                }
                return model.ElementAt(id);
            }
            catch(Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
