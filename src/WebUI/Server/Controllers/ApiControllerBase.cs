using MediatR;
using Microsoft.AspNetCore.Mvc;
using RapidBlazor2.WebUI.Server.Filters;

namespace RapidBlazor2.WebUI.Server.Controllers;

[ApiController]
[ApiExceptionFilter]
[Route("api/[controller]")]
public abstract class ApiControllerBase : ControllerBase
{
    private ISender _mediator = null!;

    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}
