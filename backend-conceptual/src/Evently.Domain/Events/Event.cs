using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Evently.Domain.Common;

namespace Evently.Domain.Events
{
    public class Event : Entity
    {
        public string Name { get; } = null!;
        public string Description { get; } = null!;
        public DateTime StartDate { get; } = DateTime.UtcNow;
        public DateTime EndDate { get; } = DateTime.UtcNow;
        public string Location { get; } = null!;
        public string OrganizerId { get; } = null!;
        public string OrganizerName { get; } = null!;
    }
}
