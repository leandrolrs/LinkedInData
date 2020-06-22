using LinkedInData.Application.DTO;
using LinkedInData.Application.Interfaces;
using LinkedInData.Domain.Core.Interfaces.Services;
using LinkedInData.Domain.Models;
using LinkedInData.Infraestructure.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace LinkedInData.Application.Services
{
    public class ApplicationServicePerson : IApplicationServicePerson
    {
        private readonly IPersonService _personService;
        private readonly IPersonMapper _personMapper;

        public ApplicationServicePerson(IPersonService personService, IPersonMapper personMapper)

        {
            _personService = personService;
            _personMapper = personMapper;
        }


        public void Add(PersonDTO obj)
        {
            var objPerson = _personMapper.MapperToEntity(obj);
            _personService.Add(objPerson);
        }

        public void Dispose()
        {
            _personService.Dispose();
        }

        public IEnumerable<PersonDTO> GetAll()
        {
            var objPersons = _personService.GetAll();
            return _personMapper.MapperPersonsList(objPersons);
        }

        public PersonDTO GetById(int id)
        {
            var objPerson = _personService.GetById(id);
            return _personMapper.MapperToDTO(objPerson);
        }

        public int GetClientPosition(int personId)
        {
            return _personService.GetClientPosition(personId);
        }

        public IEnumerable<PersonDTO> GetTopClients(int number)
        {
            var objPersons = _personService.GetTopClients(number);
            return _personMapper.MapperPersonsList(objPersons);
        }

        public void Remove(PersonDTO obj)
        {
            var objPerson = _personMapper.MapperToEntity(obj);
            _personService.Remove(objPerson);
        }

        public void Update(PersonDTO obj)
        {
            var objPerson = _personMapper.MapperToEntity(obj);
            _personService.Update(objPerson);
        }
    }
}
