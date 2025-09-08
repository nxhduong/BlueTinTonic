using Microsoft.AspNetCore.Identity;

namespace BlueTinTonic.Data;

// Add profile data for application users by adding properties to the Member class
public class Member : IdentityUser
{
    public string About { get; set; } = string.Empty;
}

