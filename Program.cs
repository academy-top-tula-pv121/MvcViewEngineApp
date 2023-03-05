using Microsoft.AspNetCore.Mvc;
using MvcViewEngineApp.ViewEngine;

namespace MvcViewEngineApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            builder.Services.Configure<MvcViewOptions>(
                options =>
                {
                    options.ViewEngines.Clear();
                    options.ViewEngines.Add(new MyViewEngine());
                });


            var app = builder.Build();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );

            app.Run();
        }
    }
}