namespace TrueRepApis.Domain.ValueObjects
{
    public sealed class FirstName
    {
        public string Value { get; }

        public FirstName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("First name cannot be null or empty");

            if (value.Length > 50)
                throw new ArgumentException("First name cannot exceed 50 characters");

            Value = value.Trim();
        }

        public static implicit operator string(FirstName firstName) => firstName.Value;
        public static explicit operator FirstName(string value) => new FirstName(value);

        public override string ToString() => Value;
        public override bool Equals(object? obj) => obj is FirstName other && Value == other.Value;
        public override int GetHashCode() => Value.GetHashCode();
    }
}
