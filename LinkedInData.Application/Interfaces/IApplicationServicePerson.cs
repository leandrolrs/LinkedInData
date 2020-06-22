using LinkedInData.Application.DTO;
using System.Collections.Generic;

namespace LinkedInData.Application.Interfaces
{
    public interface IApplicationServicePerson
    {
        void Add(PersonDTO obj);

        PersonDTO GetById(int id);

        IEnumerable<PersonDTO> GetTopClients(int number);

        int GetClientPosition(int personId);

        IEnumerable<PersonDTO> GetAll();

        void Update(PersonDTO obj);

        void Remove(PersonDTO obj);

        void Dispose();
    }
}
