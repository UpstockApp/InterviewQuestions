namespace RiskAnalysis.Domain;

public readonly record struct CompanyId(int Value) : IEquatable<int>
{
    public static implicit operator int(CompanyId id)
    {
        return id.Value;
    }

    public bool Equals(int other) => other == Value;
}

public readonly record struct BuyerId(int Value) : IEquatable<int>
{
    public static implicit operator int(BuyerId id)
    {
        return id.Value;
    }

    public static implicit operator CompanyId(BuyerId id)
    {
        return new CompanyId(id.Value);
    }
    
    public bool Equals(int other) => other == Value;
}

public readonly record struct SupplierId(int Value) : IEquatable<int>
{
    public static implicit operator int(SupplierId id)
    {
        return id.Value;
    }
    
    public static implicit operator CompanyId(SupplierId id)
    {
        return new CompanyId(id.Value);
    }

    public bool Equals(int other) => other == Value;
}