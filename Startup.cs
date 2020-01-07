using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using HelloApi.Models;
using Microsoft.AspNetCore.HttpOverrides;
using System.Net;

namespace HelloApi
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
            services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.ForwardLimit = 2;
                options.KnownProxies.Add(IPAddress.Parse("10.198.170.121"));
                options.ForwardedForHeaderName = "X-Forwarded-For-My-Custom-Header-Name";
            });
            services.Configure<CookiePolicyOptions>(options =>
            {
                
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.None;
            });

    
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<NhanvienContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("NhanvienContext")));

            
            //services.AddDbContext<MvcEmployerContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("MvcMovieContext")));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.Use((context, next) =>
            {
                context.Request.Scheme = "https";
                return next();
            });
            app.UseHttpsRedirection();

            //app.UseMvc(router =>
            //{

            //     router.MapRoute("default", "{controller = values}/{action=i}/{id?}");
            //     router.MapRoute("values", "api/{controller}/{action}/{id?}");
            //});
            //app.UseEndpoints(router => { 
            //});
            app.UseMvc(routes =>
            {
                routes
                    .MapRoute(name: "default", template: "{controller=Values}/{action=Index}/{id?}")
                    .MapRoute(name: "api", template: "api/{controller}/{action}/{id?}");
            });
            //app.UseMvc();
        }
    }
}
