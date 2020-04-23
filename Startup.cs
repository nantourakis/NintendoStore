using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NintendoStore.Models;

namespace NintendoStore
{
    public class Startup
    {
        // read only prop to help configure the DB
        //inject into constructor to be able to use it
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            //now we have access to our connction string
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // add the services we need/use here

            // connection to our database
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );

            // Add Identiy Service to work within our app
            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>();

            // include the service for MVC Pattern
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            //add our own custom service with add scope method (an instance is created with each request and remains active through whole request)
            // registers the service and where to implement it
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IGameRepository, GameRepository>();

            // add shopping cart, each user has own personal sc and will use the same one
            services.AddScoped<ShoppingCart>(sc => ShoppingCart.GetCart(sc));

            // bring in interface and set where it will be implented
            services.AddScoped<IOrderRepository, OrderRepository>();

            // set up Sessions Service
            services.AddHttpContextAccessor();
            services.AddSession();

            //support for razor pages since identity uses this
            services.AddRazorPages();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // tells the app what environment to run in, Developer by default
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Add Middleware to our IApplicationBuilder (order is important)

            //redirect to HTTPS
            app.UseHttpsRedirection();
            //enable the use of static files such as CSS and JS / searches wwwroot
            app.UseStaticFiles();
            //enable session before user moves from one page to another
            app.UseSession();

            app.UseRouting();

            //in order to use Identity
            app.UseAuthentication();

            //Add Authorization to authorize the user to log in
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //mapping - set up our controller and action routing
                //if no controller specefied, goes to to home controller
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );

                endpoints.MapRazorPages();
            });

        }
    }
}
