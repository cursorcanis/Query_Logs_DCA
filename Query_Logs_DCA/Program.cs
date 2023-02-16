using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Query_Logs_DCA.Data;
var builder = WebApplication.CreateBuilder(args);


string connectionString = builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING");

//builder.Configuration.AddAzureAppConfiguration(connectionString);


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Query_Logs_DCAContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING") ?? throw new InvalidOperationException("Connection string 'AZURE_SQL_CONNECTIONSTRING' not found.")));



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
