namespace TrueRepApis.Domain.ValueObjects
{
    public sealed class MaritalStatus
    {
        public static readonly MaritalStatus Single = new("Single");
        public static readonly MaritalStatus Married = new("Married");
        public static readonly MaritalStatus Divorced = new("Divorced");
        public static readonly MaritalStatus Widowed = new("Widowed");
        public static readonly MaritalStatus Separated = new("Separated");

        public string Value { get; }

        private MaritalStatus(string value)
        {
            Value = value;
        }

        public static MaritalStatus FromString(string value)
        {
            return value?.ToLower() switch
            {
                "single" => Single,
                "married" => Married,
                "divorced" => Divorced,
                "widowed" => Widowed,
                "separated" => Separated,
                _ => throw new ArgumentException($"Invalid marital status: {value}")
            };
        }

        public static implicit operator string(MaritalStatus status) => status.Value;

        public override string ToString() => Value;
        public override bool Equals(object? obj) => obj is MaritalStatus other && Value == other.Value;
        public override int GetHashCode() => Value.GetHashCode();
    }
}
