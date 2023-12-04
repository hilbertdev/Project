
namespace Project.Domain.Primitives
{
    public abstract class ValueObject : IEquatable<ValueObject>
    {
        public abstract IEnumerable<object> GetAtomicValues();
        private bool ValuesAreEqual(ValueObject valueObject)
        {
            return GetAtomicValues().SequenceEqual(valueObject.GetAtomicValues());
        }

        public override bool Equals(object? obj)
        {
            return obj is ValueObject valueObject && ValuesAreEqual(valueObject);
        }

        public override int GetHashCode()
        {
            return GetAtomicValues()
                .Select(x => x != null ? x.GetHashCode() : 0)
                .Aggregate((x, y) => x ^ y);
        }

        public bool Equals(ValueObject? other)
        {
            return other is not null && ValuesAreEqual(other);
        }
    }
}
