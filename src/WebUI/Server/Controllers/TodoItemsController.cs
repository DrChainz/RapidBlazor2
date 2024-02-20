using Microsoft.AspNetCore.Mvc;
using RapidBlazor2.Application.TodoItems.Commands;
using RapidBlazor2.WebUI.Shared.TodoItems;

namespace RapidBlazor2.WebUI.Server.Controllers;

public class TodoItemsController : ApiControllerBase
{
    // POST: api/TodoItems
    [HttpPost]
    public async Task<ActionResult<int>> PostTodoItem(
        CreateTodoItemRequest request)
    {
        return await Mediator.Send(new CreateTodoItemCommand(request));
    }

    // PUT: api/TodoItems/5
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType]
    public async Task<IActionResult> PutTodoItem(int id,
        UpdateTodoItemRequest request)
    {
        if (id != request.Id) return BadRequest();

        await Mediator.Send(new UpdateTodoItemCommand(request));

        return NoContent();
    }

    // DELETE: api/TodoItems/5
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesDefaultResponseType]
    public async Task<IActionResult> DeleteTodoItem(int id)
    {
        await Mediator.Send(new DeleteTodoItemCommand(id));

        return NoContent();
    }
}
