namespace TrueRepApis.Domain.ValueObjects
{
    public sealed class State
    {
        public string Name { get; }
        public string Code { get; }

        public State(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("State name cannot be null or empty");

            if (name.Length > 100)
                throw new ArgumentException("State name cannot exceed 100 characters");

            Name = name.Trim();
            Code = string.Empty;
        }

        public State(string? name, string? code)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("State name cannot be null or empty");

            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentException("State code cannot be null or empty");

            if (name.Length > 100)
                throw new ArgumentException("State name cannot exceed 100 characters");

            if (code.Length > 10)
                throw new ArgumentException("State code cannot exceed 10 characters");

            Name = name.Trim();
            Code = code.Trim();
        }

        public static implicit operator string(State state) => state.Name;
        public static explicit operator State(string name) => new State(name);

        public override string ToString() => string.IsNullOrEmpty(Code) ? Name : $"{Name} ({Code})";
        public override bool Equals(object? obj) => obj is State other && Name == other.Name && Code == other.Code;
        public override int GetHashCode() => HashCode.Combine(Name, Code);
    }
}