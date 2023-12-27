
namespace Project.Domain.Primitives.ValueObjects;

using System.Text.RegularExpressions;

public sealed partial class Email : ValueObject
{
    public string Address { get; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public Email()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {

    }

    private Regex validateEmail = MyRegex();

    public Email(string address)
    {
        if (!this.validateEmail.IsMatch(address))
        {
            throw new ArgumentException("Email address is not valid.", nameof(address));
        }

        this.Address = address;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return this.Address.ToLowerInvariant();
    }

    [GeneratedRegex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
    private static partial Regex MyRegex();
}
