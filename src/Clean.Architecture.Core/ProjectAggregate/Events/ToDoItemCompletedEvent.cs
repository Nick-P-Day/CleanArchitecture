using Clean.Architecture.SharedKernel;

namespace Clean.Architecture.Core.ProjectAggregate.Events;

public class ToDoItemCompletedEvent : DomainEventBase
{
    public ToDoItemCompletedEvent(ToDoItem completedItem)
    {
        CompletedItem = completedItem;
    }

    public ToDoItem CompletedItem { get; set; }
}
