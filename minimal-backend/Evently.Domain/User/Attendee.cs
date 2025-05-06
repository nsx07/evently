using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Evently.Domain.User.Enums;

namespace Evently.Domain.User
{
    public class Attendee
    {
        [Key]
        [ForeignKey("User")]
        public Guid Id { get; set; }
        public required string FullName { get; set; }
        public required string DocumentNumber { get; set; }
        public required EDocumentType DocumentType { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
