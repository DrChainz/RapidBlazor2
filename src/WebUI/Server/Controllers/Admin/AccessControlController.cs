﻿using Microsoft.AspNetCore.Mvc;
using RapidBlazor2.Application.AccessControl.Commands;
using RapidBlazor2.Application.AccessControl.Queries;
using RapidBlazor2.WebUI.Shared.AccessControl;
using RapidBlazor2.WebUI.Shared.Authorization;

namespace RapidBlazor2.WebUI.Server.Controllers.Admin;

[Route("api/Admin/[controller]")]
public class AccessControlController : ApiControllerBase
{
    [HttpGet]
    [Authorize(Permissions.ViewAccessControl)]
    public async Task<ActionResult<AccessControlVm>> GetConfiguration()
    {
        return await Mediator.Send(new GetAccessControlQuery());
    }

    [HttpPut]
    [Authorize(Permissions.ConfigureAccessControl)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> UpdateConfiguration(RoleDto updatedRole)
    {
        await Mediator.Send(new UpdateAccessControlCommand(updatedRole.Id, updatedRole.Permissions));

        return NoContent();
    }
}
