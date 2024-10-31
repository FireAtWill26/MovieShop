
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using ApplicationCore.Contracts.Services;
using Infrastructure.Services;
using ApplicationCore.Contracts.Repository;
using Infrastructure.Repository;
using Serilog;
using FluentValidation.AspNetCore;
using MovieShop.Utilities.CustomMiddlewares;
using Utilities.CustomFilters;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration().
    WriteTo.File("Log/filter-log-.json", rollingInterval: RollingInterval.Minute,
    restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Information,
    outputTemplate: "{Timestamp} [{Level}] {Message}{NewLine}{Exception}")
    .WriteTo.File("Log/error-log-.json", rollingInterval: RollingInterval.Minute,
    restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Error, 
    outputTemplate: "{Timestamp} [{Level}] {Message}{NewLine}{Exception}")
    .CreateLogger();

builder.Host.UseSerilog();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MovieShopAppDbContext>(option => 
    {
        option.UseSqlServer(builder.Configuration.GetConnectionString("MovieShop"));
    });

builder.Services.AddScoped<ICastRepositoryAsync, CastRepositoryAsync>();
builder.Services.AddScoped<IGenreRepositoryAsync, GenreRepositoryAsync>();
builder.Services.AddScoped<IMovieRepositoryAsync, MovieRepositoryAsync>();
builder.Services.AddScoped<IMovieServiceAsync, MovieServiceAsync>();
builder.Services.AddScoped<IGenreServiceAsync, GenreServiceAsync>();
builder.Services.AddScoped<ICastServiceAsync, CastServiceAsync>();
builder.Services.AddScoped<LogRequestFilter>();

//public void ConfigurationServices(IServiceCollection services)
//{
//    services.AddMvc(setup =>
//    {

//    }).AddFluentValidation();
//}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseLoggingExceptionMiddleware();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Movie}/{action=Index}/{id?}");

app.Run();
