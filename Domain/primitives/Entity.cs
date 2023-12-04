
namespace Project.Domain.Primitives
{
    public abstract class Entity : IEquatable<Entity>
    {
        public Guid Id { get; protected set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        protected Entity(Guid id)
        {
            Id = id;
        }

        public bool Equals(Entity? other)
        {
            if (other is null)
            {
                return false;
            }

            return ReferenceEquals(this, other) || Id.Equals(other.Id);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                return false;
            }

            return ReferenceEquals(this, obj) || Equals(obj as Entity);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ 31;
        }
    }
}
