using LinkedInData.Domain.Core.Interfaces.Repositories;
using LinkedInData.Domain.Core.Interfaces.Services;
using LinkedInData.Domain.Models;
using System.Linq;
using System.Collections.Generic;

namespace LinkedInData.Domain.Services
{
    public class PersonService : BaseService<Person>, IPersonService
    {
        public readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
            : base(personRepository)
        {
            _personRepository = personRepository;
        }

        public int GetClientPosition(int personId)
        {
            var personsList = _personRepository.GetAll()
                .Select((r, i) => new { r.PersonId, Position = i + 1});

            return (from p in personsList where p.PersonId == personId select p.Position).FirstOrDefault();
        }

        public IEnumerable<Person> GetTopClients(int number)
        {
            return _personRepository.GetAll().Take(number);
        }
    }
}
