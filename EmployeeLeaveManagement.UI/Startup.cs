using EmployeeLeaveManagement.BusinessEngine.Contracts;
using EmployeeLeaveManagement.BusinessEngine.Implementation;
using EmployeeLeaveManagement.Common.Mappings;
using EmployeeLeaveManagement.Data.Contracts;
using EmployeeLeaveManagement.Data.DataContext;
using EmployeeLeaveManagement.Data.DbModels;
using EmployeeLeaveManagement.Data.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2022204_EmployeeLeaveManagement_Core5
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
            services.AddDbContext<EmployeeLeaveManagementContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("IdentityConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<EmployeeLeaveManagementContext>();
            services.AddAutoMapper(typeof(Maps));
            //services.AddScoped<IEmployeeLeaveAllocationRepository, EmployeeLeaveAllocationRepository>();
            //services.AddScoped<IEmployeeLeaveTypeRepository, EmployeeLeaveTypeRepository>();
            //services.AddScoped<IEmployeeLeaveRequestRepository, EmployeeLeaveRequestRepository>();
            services.AddScoped<IEmployeeLeaveTypeBusinessEngine, EmployeeLeaveTypeBusinessEngine>(); // implemented unitofwork here and commented the repos above
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddRazorPages(); // bunu eklemeye gerek var mıydı???

            services.AddIdentity<Employee, IdentityRole>().AddDefaultTokenProviders()
                .AddEntityFrameworkStores<EmployeeLeaveManagementContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
