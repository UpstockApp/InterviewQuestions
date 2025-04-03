using RiskAnalysis.Domain;
using RiskAnalysis.Events.Abstractions;

namespace RiskAnalysis.Events;

public record BuyerRequestedSupplierEvent(BuyerId BuyerId, SupplierId SupplierId) : IEvent;