using LinkedInData.Application.DTO;
using LinkedInData.Domain.Models;
using System.Collections.Generic;

namespace LinkedInData.Infraestructure.CrossCutting.Adapter.Interfaces
{
    public interface IPersonMapper
    {
        #region Mappers

        Person MapperToEntity(PersonDTO personDTO);

        IEnumerable<PersonDTO> MapperPersonsList(IEnumerable<Person> persons);

        PersonDTO MapperToDTO(Person person);

        #endregion

    }
}
