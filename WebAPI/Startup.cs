using Business;
using Business.Abstract;
using Business.Concrete;
using DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
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
            services.AddSingleton<IBrandService,BrandManager>();
            services.AddSingleton<IBrandDal, EfBrandDal>();
            services.AddSingleton<IComputerService, ComputerManager>();
            services.AddSingleton<IComputerDal, EfComputerDal>();
            services.AddSingleton<IDeviceService, DeviceManager>();
            services.AddSingleton<IDeviceDal, EfDeviceDal>();
            services.AddSingleton<IEmployeeService, EmployeeManager>();
            services.AddSingleton<IEmployeeDal, EfEmployeeDal>();
            services.AddSingleton<IModelService, ModelManager>();
            services.AddSingleton<IModelDal, EfModelDal>();
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
        }
    }
}
