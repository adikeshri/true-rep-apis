namespace TrueRepApis.Domain.ValueObjects
{
    public sealed class Profession
    {
        public string Value { get; }

        public Profession(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Profession cannot be null or empty");

            Value = value.Trim();
        }

        public static implicit operator string(Profession profession) => profession.Value;
        public static explicit operator Profession(string value) => new Profession(value);

        public override string ToString() => Value;
        public override bool Equals(object? obj) => obj is Profession other && Value == other.Value;
        public override int GetHashCode() => Value.GetHashCode();
    }
}
