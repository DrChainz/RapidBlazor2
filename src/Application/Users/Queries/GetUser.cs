﻿using RapidBlazor2.Application.Common.Services.Identity;
using RapidBlazor2.WebUI.Shared.AccessControl;

namespace RapidBlazor2.Application.Users.Queries;

public record GetUserQuery(string Id) : IRequest<UserDetailsVm>;

public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserDetailsVm>
{
    private readonly IIdentityService _identityService;

    public GetUserQueryHandler(IIdentityService identityService)
    {
        _identityService = identityService;
    }

    public async Task<UserDetailsVm> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        var result = new UserDetailsVm
        {
            User = await _identityService.GetUserAsync(request.Id),
            Roles = await _identityService.GetRolesAsync(cancellationToken)
        };

        return result;
    }
}
