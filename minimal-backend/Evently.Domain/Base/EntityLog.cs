using System.ComponentModel.DataAnnotations.Schema;

namespace Evently.Domain.Base
{
    public class EntityLog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }
    }
}
