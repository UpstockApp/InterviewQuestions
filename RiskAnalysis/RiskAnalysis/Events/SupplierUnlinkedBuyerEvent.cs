using RiskAnalysis.Domain;
using RiskAnalysis.Events.Abstractions;

namespace RiskAnalysis.Events;

public record SupplierUnlinkedBuyerEvent(SupplierId SupplierId, BuyerId BuyerId, SupplierUnlinkedBuyerEvent.UnlinkReason Reason) : IEvent
{
    public enum UnlinkReason
    {
        NoLongerStocking,
        NotPayingBills,
        SuspiciousBehaviour,
        ClosedDown
    }
}