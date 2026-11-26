using Game.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using listAndDetails.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<GameDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<AppUser, IdentityRole>()
    .AddEntityFrameworkStores<GameDbContext>()
    .AddRoles<IdentityRole>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/Account/AccessDenied";
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseWhen(
    context => !context.Request.Path.StartsWithSegments("/api"),
    branch =>
    {
        branch.UseStatusCodePagesWithReExecute("/Home/Missing");
    });

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

using (var scope = app.Services.CreateScope())
{
    await RoleSeeder.SeedAsync(scope.ServiceProvider, builder.Configuration);
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapGet("/api/games/count", async (GameDbContext db) => 
    new { count = await db.Games.CountAsync() });

app.Run();