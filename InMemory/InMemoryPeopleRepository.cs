using System;
using System.Collections.Generic;

namespace Wss.People
{
    public partial class InMemoryPeopleRepository : IPeopleRepository, IPeopleRepositoryAsync
    {
        private readonly IList<Person> People = new List<Person>();

        public InMemoryPeopleRepository()
        {
            People.Add(new Person() { Identifier=Guid.NewGuid(), FirstName = "Peter", SecondName = "Danes", Email = "peter.danes@webstep.se", Phone = new Phone[] {
                new Phone() { InternationalCode = 46, Number = "735042048", Description = "Personal Mobile" },
                new Phone() { InternationalCode = 46, Number = "735042049", Description = "HomePhone" }
            }
            });
            People.Add(new Person() { Identifier = Guid.NewGuid(), FirstName = "David", SecondName = "Wallin", Email = "david.wallin@webstep.se", Phone = new Phone[] { new Phone() { InternationalCode = 46, Number = "739883320", Description = "Work Mobile" } } });
        }

    }
}
