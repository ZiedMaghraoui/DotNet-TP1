using DotNet_TP1.Models;
using DotNet_TP1.Repositories;
using DotNet_TP1.Services.ServiceContracts;
using DotNet_TP1.Services.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationdbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddScoped<GenreRepository>();
builder.Services.AddScoped<IGenreService, GenreService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//  Custom route for a ByRelease
app.MapControllerRoute(
    name: "custom",
    pattern: "Movie/released/{year}/{month}",
    defaults: new { controller = "Movie", action = "ByRelease" });

app.Run();


/*
 *     ASP.NET Web Forms Routing: ASP.NET Web Forms, which is part of the traditional ASP.NET framework, introduced routing capabilities with the System.Web.Routing namespace. This system allows you to define routes using RouteTable.Routes.MapPageRoute and works with Web Forms-based applications.

    ASP.NET MVC Routing: ASP.NET MVC (Model-View-Controller) uses a robust routing system that's defined in the System.Web.Mvc namespace. This system is highly configurable and allows you to define custom routes for your controllers and actions. It's widely used for developing modern web applications.

    ASP.NET Web API Routing: If you're building RESTful web services or APIs with ASP.NET, you'll use the routing system provided by ASP.NET Web API. It's designed for handling HTTP requests and defining routes for API controllers and actions. Web API routes are typically defined in the Global.asax or WebApiConfig.cs file.

    ASP.NET Core Routing: In ASP.NET Core, the routing system is very flexible and powerful. It's part of the Microsoft.AspNetCore.Routing namespace. You can define routes in the Startup.cs file using the UseEndpoints method, as shown in previous responses. ASP.NET Core routing is used for MVC, Razor Pages, and API applications.

    ASP.NET Razor Pages Routing: Razor Pages, a framework in ASP.NET Core, has its own routing system. You define routes in the Pages folder using the @page directive. It's suitable for building page-centric web applications.

    Attribute Routing: All the mentioned systems and frameworks also support attribute-based routing, where you can define routes directly on controllers and actions using attributes. This is a more declarative way of defining routes and is commonly used in ASP.NET Core and ASP.NET MVC.

    Third-Party Routing Libraries: You can also find third-party routing libraries, such as RouteMagic or AttributeRouting, which offer additional features and customization options for routing in ASP.NET applications.
 */
