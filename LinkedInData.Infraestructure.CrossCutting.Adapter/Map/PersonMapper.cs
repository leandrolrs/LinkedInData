using LinkedInData.Application.DTO;
using LinkedInData.Domain.Models;
using LinkedInData.Infraestructure.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedInData.Infraestructure.CrossCutting.Adapter.Map
{
    public class PersonMapper : IPersonMapper
    {

        #region properties

        List<PersonDTO> personDTOs = new List<PersonDTO>();

        #endregion


        #region methods

        public Person MapperToEntity(PersonDTO personDTO)
        {
            Person person = new Person
            {
                PersonId = personDTO.PersonId,
                FirstName = personDTO.FirstName,
                LastName = personDTO.LastName,
                CurrentRole = personDTO.CurrentRole,
                Country = personDTO.Country,
                Industry = personDTO.Industry,
                NumberOfRecommendations = personDTO.NumberOfRecommendations,
                NumberOfConnections = personDTO.NumberOfConnections
            };

            return person;

        }


        public IEnumerable<PersonDTO> MapperPersonsList(IEnumerable<Person> persons)
        {
            foreach (var person in persons)
            {


                PersonDTO personsDTO = new PersonDTO
                {
                    PersonId = person.PersonId,
                    FirstName = person.FirstName,
                    LastName = person.LastName,
                    CurrentRole = person.CurrentRole,
                    Country = person.Country,
                    Industry = person.Industry,
                    NumberOfRecommendations = person.NumberOfRecommendations,
                    NumberOfConnections = person.NumberOfConnections
                };



                personDTOs.Add(personsDTO);

            }

            return personDTOs;
        }

        public PersonDTO MapperToDTO(Person person)
        {
            PersonDTO personDTO = new PersonDTO();

            try
            {
                if (person != null)
                {
                    personDTO.PersonId = person.PersonId;
                    personDTO.FirstName = person.FirstName;
                    personDTO.LastName = person.LastName;
                    personDTO.CurrentRole = person.CurrentRole;
                    personDTO.Country = person.Country;
                    personDTO.Industry = person.Industry;
                    personDTO.NumberOfRecommendations = person.NumberOfRecommendations;
                    personDTO.NumberOfConnections = person.NumberOfConnections;
                }


            }
            catch (Exception)
            {

                throw;
            }



            return personDTO;

        }

        #endregion

    }
}
