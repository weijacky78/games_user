using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);


var dbmsVersion = new MariaDbServerVersion(builder.Configuration.GetValue<string>("DBMSVersion"));
var connString = builder.Configuration.GetConnectionString("StoreContext");

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<StoreContext>(options =>
    options.UseMySql(connString, dbmsVersion));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
