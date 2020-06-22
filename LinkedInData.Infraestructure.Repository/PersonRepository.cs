using LinkedInData.Domain.Core.Interfaces.Repositories;
using LinkedInData.Domain.Models;
using LinkedInData.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace LinkedInData.Infraestructure.Repository
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        private readonly SqlContext _context;
        public PersonRepository(SqlContext context)
            : base(context)
        {
            _context = context;
        }


        public override IEnumerable<Person> GetAll()
        {
            return (from p in _context.Persons
                    join c in _context.Countries on p.Country equals c.Name
                    orderby c.Priority, p.NumberOfRecommendations descending, p.NumberOfConnections descending
                    select p).ToList();

        }
    }
}
