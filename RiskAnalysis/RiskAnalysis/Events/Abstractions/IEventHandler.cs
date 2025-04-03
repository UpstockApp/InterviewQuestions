namespace RiskAnalysis.Events.Abstractions;

public interface IEventHandler<TEvent> where TEvent : IEvent
{
    Task Handle(TEvent e, EventMetadata meta, CancellationToken token);
}