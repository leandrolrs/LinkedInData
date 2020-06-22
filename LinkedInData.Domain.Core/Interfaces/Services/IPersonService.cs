
using LinkedInData.Domain.Models;
using System.Collections.Generic;

namespace LinkedInData.Domain.Core.Interfaces.Services
{
    public interface IPersonService : IBaseService<Person>
    {
        IEnumerable<Person> GetTopClients(int number);

        int GetClientPosition(int personId);
    }
}
