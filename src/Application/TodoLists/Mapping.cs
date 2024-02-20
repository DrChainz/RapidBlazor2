using RapidBlazor2.WebUI.Shared.TodoLists;

namespace RapidBlazor2.Application.TodoLists;

public class Mapping : Profile
{
    public Mapping()
    {
        CreateMap<TodoList, TodoListDto>();
        CreateMap<TodoItem, TodoItemDto>();
    }
}
