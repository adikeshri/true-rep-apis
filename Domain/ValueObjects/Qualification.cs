namespace TrueRepApis.Domain.ValueObjects
{
    public sealed class Qualification
    {
        public string Value { get; }

        public Qualification(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Qualification cannot be null or empty");

            Value = value.Trim();
        }

        public static implicit operator string(Qualification qualification) => qualification.Value;
        public static explicit operator Qualification(string value) => new Qualification(value);

        public override string ToString() => Value;
        public override bool Equals(object? obj) => obj is Qualification other && Value == other.Value;
        public override int GetHashCode() => Value.GetHashCode();
    }
}
