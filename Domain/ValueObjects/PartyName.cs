namespace TrueRepApis.Domain.ValueObjects
{
    public sealed class PartyName
    {
        public string FullName { get; }
        public string ShortName { get; }

        public PartyName(string fullName, string shortName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Party full name cannot be null or empty");

            if (string.IsNullOrWhiteSpace(shortName))
                throw new ArgumentException("Party short name cannot be null or empty");

            FullName = fullName.Trim();
            ShortName = shortName.Trim();
        }

        public override string ToString() => $"{FullName} ({ShortName})";
        public override bool Equals(object? obj) => obj is PartyName other && FullName == other.FullName && ShortName == other.ShortName;
        public override int GetHashCode() => HashCode.Combine(FullName, ShortName);
    }
}
