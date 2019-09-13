using System;
using System.Collections.Generic;
using System.IO;

namespace Wss.People
{
    public class Person
    {
        public Person() { }
        public Person(Person person, bool copyPhoneNumbers)
        {
            FirstName = person.FirstName;
            SecondName = person.SecondName;
            Email = person.Email;
            Identifier = person.Identifier;
            if(copyPhoneNumbers)
            {
                Phone = new List<Phone>(person.Phone);
            }
        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public string Email { get; set; }
        public IEnumerable<Phone> Phone { get; set; }

        public Guid Identifier { get; set; }
    }
}
