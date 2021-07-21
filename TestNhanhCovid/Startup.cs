using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestNhanhCovid.Repository;
using TestNhanhCovid.Services;

namespace TestNhanhCovid
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public class ConnectionStrings
        {
            public string SqlServer { get; set; }

            public string SqlFpt { get; set; }
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<ConnectionStrings>(Configuration.GetSection("ConnectionStrings"));

            services.AddControllersWithViews();

            //Register dapper in scope    
            services.AddScoped<IDapperService, DapperService>();
            services.AddTransient<IKetQuaTestNhanhRepo, KetQuaTestNhanhRepo>();
            services.AddTransient<ILayMauTestNhanhRepo, LayMauTestNhanhRepo>();
            //services.AddTransient<IToKhaiYTeRepo, ToKhaiRepo>();
            //services.AddTransient<IThongTinHcRepo, ThongTinHcRepo>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            loggerFactory.AddFile("Logs/mylog-{Date}.txt");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
