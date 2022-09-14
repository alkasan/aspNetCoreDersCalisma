using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspNetCoreDersCalisma
{
    
    public class Startup
    {
        
            // This method gets called by the runtime. Use this method to add services to the container.
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddMvc();
                //MvcOptions.EnableEndpointRouting =
                services.AddMvc(option => option.EnableEndpointRouting = false);


            }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(ConfigureRoutes);
        }
        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index2}/{id?}");
            routeBuilder.MapRoute("MyRoute", "Engin/{controller=Home}/{action=Index3}/{id?}");
        }

          //      app.UseRouting();

          //      app.UseEndpoints(endpoints =>
          //      {
          //          endpoints.MapGet("/", async context =>
          //          {
          //              await context.Response.WriteAsync("Hello World!");
          //          });
          //      });
          //  }
          }
        }
    
