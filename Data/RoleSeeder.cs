using Game.Models;
using Microsoft.AspNetCore.Identity;

namespace listAndDetails.Data;

public static class RoleSeeder
{
    public static async Task SeedAsync(
        IServiceProvider services,
        IConfiguration configuration)
    {
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = services.GetRequiredService<UserManager<AppUser>>();
        const string roleName = "RegistryAdmin";

        if (!await roleManager.RoleExistsAsync(roleName))
        {
            await roleManager.CreateAsync(new IdentityRole(roleName));
        }

        var adminEmail = configuration["Admin:Email"];
        if (string.IsNullOrWhiteSpace(adminEmail))
        {
            return;
        }

        var admin = await userManager.FindByEmailAsync(adminEmail);
        if (admin != null && !await userManager.IsInRoleAsync(admin, roleName))
        {
            await userManager.AddToRoleAsync(admin, roleName);
        }
    }
}
