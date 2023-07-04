namespace Domain;

public interface IEntity
{
    object Id { get; set; }
}

public interface IEntity<TId> : IEntity where TId : struct
{
    new TId Id { get; set; }
}

[Serializable]
public class Entity<TId> : IEntity<TId> where TId : struct
{
    protected Entity()
    {
    }

    public Entity(TId id)
    {
        Id = id;
    }

    public TId Id { get; set; }

    object IEntity.Id
    {
        get => Id;
        set => Id = (TId)value;
    }
}

[Serializable]
public class Entity : Entity<int>
{
    public Entity()
    {
    }

    public Entity(int id) : base(id)
    {
    }
}

[Serializable]
public class NamedEntity : Entity
{
    public string Name { get; set; } = default!;
}