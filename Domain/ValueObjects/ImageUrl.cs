namespace TrueRepApis.Domain.ValueObjects
{
    public sealed class ImageUrl
    {
        public string Value { get; }

        public ImageUrl(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Image URL cannot be null or empty");

            if (!Uri.TryCreate(value, UriKind.Absolute, out var uri) || 
                (uri.Scheme != Uri.UriSchemeHttp && uri.Scheme != Uri.UriSchemeHttps))
                throw new ArgumentException("Image URL must be a valid HTTP or HTTPS URL");

            if (value.Length > 500)
                throw new ArgumentException("Image URL cannot exceed 500 characters");

            Value = value.Trim();
        }

        public static implicit operator string(ImageUrl imageUrl) => imageUrl.Value;
        public static explicit operator ImageUrl(string value) => new ImageUrl(value);

        public override string ToString() => Value;
        public override bool Equals(object? obj) => obj is ImageUrl other && Value == other.Value;
        public override int GetHashCode() => Value.GetHashCode();
    }
}
