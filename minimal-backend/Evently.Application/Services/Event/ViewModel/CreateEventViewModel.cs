namespace Evently.Application.Services.Event.ViewModel
{
    public class CreateEventViewModel
    {
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
        public required string Title { get; set; }
        public required string Location { get; set; }
        public string? PrincipalImageUrl { get; set; }
        public required string Description { get; set; }
        public bool IsOnline { get; set; }
        public bool IsActive { get; set; }
        public bool IsOnlyAdults { get; set; }
        public int MaxAttendees { get; set; }
    }
}
