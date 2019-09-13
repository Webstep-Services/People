using AutoMapper;
using Wss.People.WebApi.Models;

namespace Wss.People.Rest.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            this.CreateMap<Person, PersonModel>().ForMember(model => model.Name, 
                                                            person => person.MapFrom(s => $"{s.SecondName}, {s.FirstName}"));
        }
    }
}
