using Evently.Domain.Ticket.Enums;
using Evently.Domain.User.Enums;

namespace Evently.Domain.Ticket
{
    public class TicketOrder
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid EventId { get; set; }
        public DateOnly BirthDate { get; set; }
        public string? DiscountCode { get; set; }
        public required string FullName { get; set; }
        public required string DocumentNumber { get; set; }
        public required EDocumentType DocumentType { get; set; }
        public required EPaymentMethod PaymentMethod { get; set; }
    }
}
