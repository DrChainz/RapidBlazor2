using RapidBlazor2.Domain.Common;
using RapidBlazor2.Domain.Entities;

namespace RapidBlazor2.Domain.Events;

public class TodoItemCompletedEvent : BaseEvent
{
    public TodoItemCompletedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}
