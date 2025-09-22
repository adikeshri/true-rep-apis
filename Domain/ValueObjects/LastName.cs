namespace TrueRepApis.Domain.ValueObjects
{
    public sealed class LastName
    {
        public string Value { get; }

        public LastName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Last name cannot be null or empty");

            if (value.Length > 50)
                throw new ArgumentException("Last name cannot exceed 50 characters");

            Value = value.Trim();
        }

        public static implicit operator string(LastName lastName) => lastName.Value;
        public static explicit operator LastName(string value) => new LastName(value);

        public override string ToString() => Value;
        public override bool Equals(object? obj) => obj is LastName other && Value == other.Value;
        public override int GetHashCode() => Value.GetHashCode();
    }
}
