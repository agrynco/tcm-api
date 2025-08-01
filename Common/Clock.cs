namespace Common;

/// <summary>
///     Provides access to the current date and time. This abstraction
///     allows deterministic control over time in tests and other
///     environments where predictable values are required.
/// </summary>
public interface IClock
{
    /// <summary>
    ///     Gets the current local date and time.
    /// </summary>
    DateTime Now { get; }

    /// <summary>
    ///     Gets today's date in the local time zone.
    /// </summary>
    DateOnly Today { get; }

    /// <summary>
    ///     Returns the next occurrence of the specified day of week.
    /// </summary>
    /// <param name="dayOfWeek">The desired day of week.</param>
    /// <returns>The upcoming date that falls on <paramref name="dayOfWeek"/>.</returns>
    DateOnly GetNearestDayOfWeek(DayOfWeek dayOfWeek);

    /// <summary>
    ///     Gets the last day of the current month.
    /// </summary>
    /// <returns>The final date in the month of <see cref="Today"/>.</returns>
    DateOnly GetTheLastDayInTheCurrentMonth();

    /// <summary>
    ///     Gets the first day of the next month.
    /// </summary>
    /// <returns>The date representing the beginning of the next month.</returns>
    DateOnly GetTheNextMonthBegin();

    /// <summary>
    ///     Gets the current time in Coordinated Universal Time (UTC).
    /// </summary>
    DateTime UtcNow { get; }
}

public class Clock : IClock
{
    private readonly TimeSpan _initialShift;

    public Clock() : this(DateTime.Now)
    {
    }

    public Clock(DateTime currentDateTime)
    {
        _initialShift = DateTime.Now - currentDateTime;
    }

    public DateTime Now => DateTime.Now - _initialShift;
    public DateOnly Today => new(Now.Year, Now.Month, Now.Day);

    public DateOnly GetNearestDayOfWeek(DayOfWeek dayOfWeek)
    {
        int daysToAdd = ((int)dayOfWeek - (int)Today.DayOfWeek + 7) % 7;

        if (daysToAdd == 0)
        {
            daysToAdd += 7;
        }

        return Today.AddDays(daysToAdd);
    }

    public DateOnly GetTheLastDayInTheCurrentMonth()
    {
        var beginOfTheCurrentMonth = new DateOnly(Now.Year, Now.Month, 1);
        return beginOfTheCurrentMonth.AddMonths(1).AddDays(-1);
    }

    public DateOnly GetTheNextMonthBegin()
    {
        DateTime nextMonthDate = Now.AddMonths(1);
        return new DateOnly(nextMonthDate.Year, nextMonthDate.Month, 1);
    }

    public DateTime UtcNow => Now.ToUniversalTime();
}
