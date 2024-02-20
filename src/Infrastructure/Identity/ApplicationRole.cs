using Microsoft.AspNetCore.Identity;
using RapidBlazor2.WebUI.Shared.Authorization;

namespace RapidBlazor2.Infrastructure.Identity;

public class ApplicationRole : IdentityRole
{
    public Permissions Permissions { get; set; }
}
