using RapidBlazor2.Domain.Common;

namespace RapidBlazor2.Domain.Entities;

public class TodoList : BaseAuditableEntity
{
    public string Title { get; set; } = string.Empty;

    public string Colour { get; set; } = string.Empty;

    public ICollection<TodoItem> Items { get; set; }
        = new List<TodoItem>();
}
