namespace RiskAnalysis.Domain;

public readonly record struct UserId(int Value) : IEquatable<int>
{
    public static implicit operator int(UserId id)
    {
        return id.Value;
    }

    public bool Equals(int other) => other == Value;
}