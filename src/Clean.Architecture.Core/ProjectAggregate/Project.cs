using Ardalis.GuardClauses;
using Clean.Architecture.Core.ProjectAggregate.Events;
using Clean.Architecture.SharedKernel;
using Clean.Architecture.SharedKernel.Interfaces;

namespace Clean.Architecture.Core.ProjectAggregate;

public class Project : EntityBase, IAggregateRoot
{
    private readonly List<ToDoItem> _items = new();

    public Project(string name, PriorityStatus priority)
    {
        Name = Guard.Against.NullOrEmpty(name, nameof(name));
        Priority = priority;
    }

    public IEnumerable<ToDoItem> Items => _items.AsReadOnly();
    public string Name { get; private set; }
    public PriorityStatus Priority { get; }
    public ProjectStatus Status => _items.All(i => i.IsDone) ? ProjectStatus.Complete : ProjectStatus.InProgress;

    public void AddItem(ToDoItem newItem)
    {
        Guard.Against.Null(newItem, nameof(newItem));
        _items.Add(newItem);

        var newItemAddedEvent = new NewItemAddedEvent(this, newItem);
        base.RegisterDomainEvent(newItemAddedEvent);
    }

    public void UpdateName(string newName)
    {
        Name = Guard.Against.NullOrEmpty(newName, nameof(newName));
    }
}
