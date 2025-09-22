namespace TrueRepApis.Domain.ValueObjects
{
    public sealed class DateOfBirth
    {
        public DateTime Value { get; }

        public DateOfBirth(DateTime value)
        {
            var today = DateTime.Today;

            Value = value.Date;
        }

        public int Age => DateTime.Today.Year - Value.Year - (DateTime.Today.DayOfYear < Value.DayOfYear ? 1 : 0);

        public static implicit operator DateTime(DateOfBirth dob) => dob.Value;
        public static explicit operator DateOfBirth(DateTime value) => new(value);

        public override string ToString() => Value.ToString("yyyy-MM-dd");
        public override bool Equals(object? obj) => obj is DateOfBirth other && Value == other.Value;
        public override int GetHashCode() => Value.GetHashCode();
    }
}
