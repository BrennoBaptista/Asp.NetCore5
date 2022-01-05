using RestApi.Data.Converter.Contract;
using RestApi.Data.DTO;
using RestApi.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestApi.Data.Converter.Implementation
{
    public class PersonConverter : IParser<PersonDTO, Person>, IParser<Person, PersonDTO>
    {
        public PersonDTO Parse(Person origin)
        {
            if (origin == null)
                return null;
            else
                return new PersonDTO
                {
                    Id = origin.Id,
                    FirstName = origin.FirstName,
                    LastName = origin.LastName,
                    Address = origin.Address,
                    Gender = origin.Address
                };
        }

        public Person Parse(PersonDTO origin)
        {
            if (origin == null)
                return null;
            else
                return new Person
                {
                    Id = origin.Id,
                    FirstName = origin.FirstName,
                    LastName = origin.LastName,
                    Address = origin.Address,
                    Gender = origin.Address
                };
        }

        public List<PersonDTO> Parse(List<Person> origin)
        {
            if (origin == null)
                return null;
            else
                return origin.Select(item => Parse(item)).ToList();
        }

        public List<Person> Parse(List<PersonDTO> origin)
        {
            if (origin == null)
                return null;
            else
                return origin.Select(item => Parse(item)).ToList();
        }
    }
}
