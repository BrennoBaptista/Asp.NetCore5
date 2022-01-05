using RestApi.Data.Converter.Implementation;
using RestApi.Data.DTO;
using RestApi.Model;
using RestApi.Repository.Generic;
using System.Collections.Generic;

namespace RestApi.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;
        private readonly PersonConverter _converter;

        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public PersonDTO Create(PersonDTO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public List<PersonDTO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public PersonDTO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        public PersonDTO Update(PersonDTO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
