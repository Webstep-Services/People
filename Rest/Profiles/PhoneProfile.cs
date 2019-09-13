using AutoMapper;
using Wss.People.WebApi.Models;

namespace Wss.People.Rest.Profiles
{
public class PhoneProfile : Profile
    {
        public PhoneProfile()
        {
            this.CreateMap<Phone, PhoneModel>().ForMember(model => model.Details,
                                                            phone => phone.MapFrom(s => $"+{s.InternationalCode} (0){s.Number} [{s.Description}]"));
        }
    }
}