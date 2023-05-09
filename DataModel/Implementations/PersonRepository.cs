using DataModel.Domain;
using DataModel.Domain.Custom;
using DataModel.Interfaces;
using System;
using System.Collections.Generic;

namespace DataModel.Implementations
{
    internal class PersonRepository : IPersonRepository
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Person GetById(int id)
        {
            throw new NotImplementedException();
        }

        public PersonQuery GetPersonDetails(Person person)
        {
            throw new NotImplementedException();
        }

        public Person Insert(Person entity)
        {
            throw new NotImplementedException();
        }

        public List<Person> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
