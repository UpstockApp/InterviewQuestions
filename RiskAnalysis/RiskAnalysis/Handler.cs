using RiskAnalysis.Events;
using RiskAnalysis.Events.Abstractions;

namespace RiskAnalysis;

public class Handler : IEventHandler<BuyerRequestedSupplierEvent>
{
    public Task Handle(BuyerRequestedSupplierEvent e, EventMetadata meta, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}