using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evently.Domain.User
{
    public class Organizer
    {
        [Key]
        [ForeignKey("User")]
        public Guid Id { get; set; }
        public required string CompanyName { get; set; }
        public required string CNPJ { get; set; }
        public required string Email { get; set; }
        public string? Biography { get; set; }
        public string? LogoUrl { get; set; }
        public string? WebsiteUrl { get; set; }
    }
}
