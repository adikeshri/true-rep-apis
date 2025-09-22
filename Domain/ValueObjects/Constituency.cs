
namespace TrueRepApis.Domain.ValueObjects;


public sealed class Constituency
{
    public string Name { get; }
    public string Code { get; }

    public Constituency(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Constituency name cannot be null or empty");

        if (name.Length > 100)
            throw new ArgumentException("Constituency name cannot exceed 100 characters");

        Name = name.Trim();
        Code = string.Empty;
    }

    public Constituency(string name, string code)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Constituency name cannot be null or empty");

        if (string.IsNullOrWhiteSpace(code))
            throw new ArgumentException("Constituency code cannot be null or empty");

        if (name.Length > 100)
            throw new ArgumentException("Constituency name cannot exceed 100 characters");

        if (code.Length > 20)
            throw new ArgumentException("Constituency code cannot exceed 20 characters");

        Name = name.Trim();
        Code = code.Trim();
    }

    public static implicit operator string(Constituency constituency) => constituency.Name;
    public static explicit operator Constituency(string name) => throw new InvalidOperationException("Cannot create constituency from string alone - state is required");

    public override string ToString() => string.IsNullOrEmpty(Code) ? $"{Name}" : $"{Name} ({Code})";
    public override bool Equals(object? obj) => obj is Constituency other && Name == other.Name && Code == other.Code;
    public override int GetHashCode() => HashCode.Combine(Name, Code);
}