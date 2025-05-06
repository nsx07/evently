namespace Evently.Domain.Ticket
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid EventId { get; set; }
        public Guid TicketOrderId { get; set; }
        public string? TicketCode { get; set; }
        public decimal Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public bool IsUsed { get; set; }
    }
}
