﻿using RapidBlazor2.Application.Common.Services.Identity;
using RapidBlazor2.WebUI.Shared.AccessControl;

namespace RapidBlazor2.Application.Users.Commands;

public record UpdateUserCommand(UserDto User) : IRequest;

public class UpdateUserCommandHandler : AsyncRequestHandler<UpdateUserCommand>
{
    private readonly IIdentityService _identityService;

    public UpdateUserCommandHandler(IIdentityService identityService)
    {
        _identityService = identityService;
    }

    protected override async Task Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        await _identityService.UpdateUserAsync(request.User);
    }
}
