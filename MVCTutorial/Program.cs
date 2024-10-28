
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using ApplicationCore.Contracts.Services;
using Infrastructure.Services;
using ApplicationCore.Contracts.Repository;
using Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

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
builder.Services.AddScoped<IGenreServiceAsnyc, GenreServiceAsync>();
builder.Services.AddScoped<ICastServiceAsync, CastServiceAsync>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
