using Evently.Application.Reminders.Commands.SetReminder;
using Evently.Application.Reminders.Queries.GetReminder;
using Evently.Application.Reminders.Queries.ListReminders;
using Evently.Domain.Reminders;

using ErrorOr;

using FluentAssertions;

using MediatR;

namespace TestCommon.Reminders;

public static class MediatorExtensions
{
    public static async Task<Reminder> SetReminderAsync(
        this IMediator mediator,
        SetReminderCommand? command = null)
    {
        command ??= ReminderCommandFactory.CreateSetReminderCommand();
        var result = await mediator.Send(command);

        result.IsError.Should().BeFalse();
        result.Value.AssertCreatedFrom(command);

        return result.Value;
    }

    public static async Task<ErrorOr<List<Reminder>>> ListRemindersAsync(
        this IMediator mediator,
        ListRemindersQuery? query = null)
    {
        return await mediator.Send(query ?? ReminderQueryFactory.CreateListRemindersQuery());
    }

    public static async Task<ErrorOr<Reminder>> GetReminderAsync(
        this IMediator mediator,
        GetReminderQuery? query = null)
    {
        query ??= ReminderQueryFactory.CreateGetReminderQuery();
        return await mediator.Send(query);
    }
}
