using PersonalWork.Application;
using PersonalWork.Application.Common.Mapping;
using PersonalWork.Application.Utils;
using PersonalWork.Infrastructure;
using PersonalWork.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using PersonalWork.API.Infrastructure;
using PersonalWork.Infrastructure.LocalDB;
using PersonalWork.API.Infrastructure;

namespace PersonalWork.API
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
            services.AddDbContext<FtoysContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Inventory"));
            });
            services.AddControllers();
            services.AddSwagger();
            services.AddJwtAuthentication(Configuration);
            services.AddApplication();
            services.AddPersistance(Configuration);
            //services.AddAmazonServices(Configuration);
            services.AddMemoryCache();
            services.AddCors();
            services.AddHttpContextAccessor();
            services.AddScoped<UserHelper>();
            //services.AddScoped<ScheduleActivityHelper>();
            services.AddAutoMapper(typeof(MappingProfile));
            //services.AddRateLimitService(Configuration);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(
                 options => options
                     .AllowAnyOrigin()
                     .AllowAnyHeader()
                     .AllowAnyMethod()
             );

            // app.UseMiddleware<ErrorHandlingMiddleware>();

            app.UseSwagger(
                  c => c.SerializeAsV2 = true
                 );
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "GateWayApi");
                c.InjectJavascript("/swagger/ui/custom.js");
                c.InjectStylesheet("/swagger/ui/custom.css");
                c.SwaggerEndpoint("/swagger/v1/swagger.yaml", "GateWayApi");
            }
                );
            app.UseStaticFiles();


            //app.UseDatabaseMigration();


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(builder => builder
               .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());

            app.UseAuthentication();
            app.UseAuthorization();
            //app.UseMiddleware<BlackListTokenMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
