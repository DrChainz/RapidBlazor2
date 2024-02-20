using RapidBlazor2.Domain.Common;
using RapidBlazor2.Domain.Entities;

namespace RapidBlazor2.Domain.Events;

public class TodoItemCreatedEvent : BaseEvent
{
    public TodoItemCreatedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}
