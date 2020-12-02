using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZemogaPost.Business.Interfaces.Repositories;
using ZemogaPost.Business.Interfaces.Services;
using ZemogaPost.Business.Services;
using ZemogaPost.Infraestructure.Persistense.Context;
using ZemogaPost.Infraestructure.Persistense.Repositories;

namespace ZemogaPost.API
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
            services.AddControllers();
            services.AddDbContext<BlogDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddHttpClient();
            //services.AddCors();
            // Invocación inyección de dependencias
            DependenciesInjection(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            //app.UseCors(
            // options => options.WithOrigins("http://localhost:30718/").AllowAnyMethod()
            //);
            //app.UseCors(options => options.AllowAnyOrigin());
        }

        private void DependenciesInjection(IServiceCollection services)
        {
            //Services
            services.AddTransient<IPostService, PostService>(); 
            services.AddTransient<ICommentService, CommentService>();
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));

            //Repository
            services.AddTransient<IPostRepository, PostRepository>();
            services.AddTransient<ICommentRepository, CommentRepository>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}
