using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.Architecture.SharedKernel;

public abstract class EntityBase
{
    private readonly List<DomainEventBase> _domainEvents = new();

    [NotMapped]
    public IEnumerable<DomainEventBase> DomainEvents => _domainEvents.AsReadOnly();

    public int Id { get; set; }

    internal void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    protected void RegisterDomainEvent(DomainEventBase domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}
