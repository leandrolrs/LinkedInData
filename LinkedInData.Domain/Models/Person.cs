using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinkedInData.Domain.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CurrentRole { get; set; }
        public string Country { get; set; }
        public string Industry { get; set; }
        public int? NumberOfRecommendations { get; set; }
        public int? NumberOfConnections { get; set; }

    }

}
