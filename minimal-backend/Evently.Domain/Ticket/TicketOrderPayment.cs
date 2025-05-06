using Evently.Domain.Ticket.Enums;

namespace Evently.Domain.Ticket
{
    public class TicketOrderPayment
    {
        public Guid Id { get; set; }
        public Guid TicketOrderId { get; set; }
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }
        public DateTime PaymentDate { get; set; }
        public required EPaymentMethod PaymentMethod { get; set; } 
        public required EPaymentStatus PaymentStatus { get; set; } 
    }
}
