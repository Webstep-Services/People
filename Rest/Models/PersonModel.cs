namespace Wss.People.Rest.Models
{
    public class PersonModel
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public PhoneModel[] Phone { get; set; }
    }
}
