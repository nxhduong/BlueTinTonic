using Microsoft.AspNetCore.Identity;
using BlueTinTonic.Data;

namespace BlueTinTonic.Components.Account;

internal sealed class IdentityUserAccessor(UserManager<Member> userManager, IdentityRedirectManager redirectManager)
{
    public async Task<Member> GetRequiredUserAsync(HttpContext context)
    {
        var user = await userManager.GetUserAsync(context.User);

        if (user is null)
        {
            redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
        }

        return user;
    }
}
