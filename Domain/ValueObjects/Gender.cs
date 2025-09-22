namespace TrueRepApis.Domain.ValueObjects
{
    public sealed class Gender
    {
        public static readonly Gender Male = new("Male");
        public static readonly Gender Female = new("Female");
        public static readonly Gender Other = new("Other");
        public static readonly Gender PreferNotToSay = new("Prefer Not To Say");

        public string Value { get; }

        private Gender(string value)
        {
            Value = value;
        }

        public static Gender FromString(string value)
        {
            return value?.ToLower() switch
            {
                "male" => Male,
                "female" => Female,
                "other" => Other,
                "prefer not to say" => PreferNotToSay,
                _ => throw new ArgumentException($"Invalid gender value: {value}")
            };
        }

        public static implicit operator string(Gender gender) => gender.Value;

        public override string ToString() => Value;
        public override bool Equals(object? obj) => obj is Gender other && Value == other.Value;
        public override int GetHashCode() => Value.GetHashCode();
    }
}
