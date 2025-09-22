namespace TrueRepApis.Domain.ValueObjects
{
    public sealed class Id(int value)
    {
        public int Value { get; } = value;
    }
}
