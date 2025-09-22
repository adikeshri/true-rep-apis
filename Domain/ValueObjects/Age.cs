namespace TrueRepApis.Domain.ValueObjects
{
    public sealed class Age
    {
        public int Value { get; }

        public Age(int value)
        {
            if (value < 0 || value > 150)
                throw new ArgumentException("Age must be between 0 and 150");

            Value = value;
        }

        public static implicit operator int(Age age) => age.Value;
        public static explicit operator Age(int value) => new Age(value);

        public override string ToString() => Value.ToString();
        public override bool Equals(object? obj) => obj is Age other && Value == other.Value;
        public override int GetHashCode() => Value.GetHashCode();
    }
}
