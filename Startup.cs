using JsonApiDotNetCore.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpinionAte.Models;
using System.Linq;

namespace OpinionAte
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseInMemoryDatabase("OpinionAte");
            });
            services.AddJsonApi<AppDbContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, AppDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            context.Database.EnsureCreated();
            if (context.Restaurants.Any() == false)
            {
                Restaurant sushiPlace = new Restaurant { Name = "Sushi Place" };
                Restaurant burgerPlace = new Restaurant { Name = "Burger Place" };
                context.Restaurants.Add(sushiPlace);
                context.Restaurants.Add(burgerPlace);
                context.SaveChanges();

                context.Dishes.Add(new Dish
                {
                    Restaurant = sushiPlace,
                    Name = "California Roll"
                });

                context.Dishes.Add(new Dish
                {
                    Restaurant = sushiPlace,
                    Name = "Volcano Roll"
                });

                context.Dishes.Add(new Dish
                {
                    Restaurant = burgerPlace,
                    Name = "Barbecue Burger",
                });

                context.Dishes.Add(new Dish
                {
                    Restaurant = burgerPlace,
                    Name = "Slider"
                });

                context.SaveChanges();
            }

            app.UseJsonApi();


        }
    }
}