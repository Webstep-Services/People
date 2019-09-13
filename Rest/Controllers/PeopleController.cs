using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Wss.People.Rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class PeopleController : ControllerBase
    {
        public IPeopleRepositoryAsync Repository { get; }
        public IMapper Mapper { get; }

        public PeopleController(IPeopleRepositoryAsync repository, IMapper mapper)
        {
            Repository = repository;
            Mapper = mapper;
        }
    }
}
