﻿namespace RapidBlazor2.WebUI.Shared.AccessControl;

public class UserDetailsVm
{
    public IList<RoleDto> Roles { get; set; } = new List<RoleDto>();

    public UserDto User { get; set; } = new UserDto();
}
