using Microsoft.AspNetCore.Identity;

namespace Day64DemoAuthentication.Data;

public class ApplicationIdentityUser : IdentityUser
{
    public int Age { get; set; }
}