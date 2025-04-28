namespace Evently.Contracts.Reminders;

public record CreateReminderRequest(string Text, DateTimeOffset DateTime);