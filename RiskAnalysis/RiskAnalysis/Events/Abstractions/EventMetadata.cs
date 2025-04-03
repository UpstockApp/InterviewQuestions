using RiskAnalysis.Domain;

namespace RiskAnalysis.Events.Abstractions;

public record EventMetadata(UserId UserId, DateTime ActionDateUtc);