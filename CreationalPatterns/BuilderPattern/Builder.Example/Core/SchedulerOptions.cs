namespace Builder.Example.Core;

public class SchedulerOptions(string cronExpression)
{
    public string CronExpression { get; } = cronExpression;
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime EndDate { get; set; } = DateTime.Now.AddYears(1);
    public Action? ActionToExecute { get; set; }
    public int? NumberOfTimesToExecute { get; set; }
}