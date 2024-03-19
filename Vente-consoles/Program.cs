using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Vente_consoles.Data;
using Vente_consoles.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Vente_consolesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Vente_consolesContext") ?? throw new
InvalidOperationException("Connection string 'Vente_consolesContext' not found.")));



// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Initialize(services);
}
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
