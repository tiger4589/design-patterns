namespace Builder.Example.Core;

public class SchedulerOptionsBuilder(string cronExpression)
{
    private readonly SchedulerOptions _options = new(cronExpression);

    public SchedulerOptions Build() => _options;

    public SchedulerOptionsBuilder WithStartDate(DateTime startDate)
    {
        _options.StartDate = startDate;
        return this;
    }

    public SchedulerOptionsBuilder WithEndDate(DateTime endDate)
    {
        _options.EndDate = endDate;
        return this;
    }

    public SchedulerOptionsBuilder WithStartAndEndDate(DateTime startDate, DateTime endDate)
    {
        _options.StartDate = startDate;
        _options.EndDate = endDate;
        return this;
    }

    public SchedulerOptionsBuilder WithActionToExecute(Action action)
    {
        _options.ActionToExecute = action;
        return this;
    }

    public SchedulerOptionsBuilder WithNumberOfTimesToExecute(int numberOfTimes)
    {
        _options.NumberOfTimesToExecute = numberOfTimes;
        return this;
    }
}