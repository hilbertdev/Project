
namespace Project.Domain.Primitives.ValueObjects;
    public sealed class Email : ValueObject
    {
        public string Address { get; }

    public Email()
    {
        
    }

    public Email(string address)
    {
        if (string.IsNullOrWhiteSpace(address))
        {
            throw new ArgumentException("Email address cannot be empty or whitespace.", nameof(address));
        }

        Address = address;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Address.ToLowerInvariant();
    }
}
