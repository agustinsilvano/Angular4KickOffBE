using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular4KickOffBE.Service;
using Angular4KickOffBE.Service.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Angular4KickOffBE
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

       // readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<IFeedService, FeedService>();

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        //services.AddCors(options =>
        //{
        //    options.AddPolicy(MyAllowSpecificOrigins,
        //    builder =>
        //    {
        //        builder.WithOrigins("http://localhost:4200").AllowAnyHeader();
        //    });
        //});

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            app.UseCors("CorsPolicy");

            app.UseMvc();

        }
    }
}
