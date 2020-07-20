using AcademiaFit.Application.Interfaces;
using AcademiaFit.Application.Services;
using AcademiaFit.Domain.Interfaces.IRepository;
using AcademiaFit.Domain.Interfaces.IService;
using AcademiaFit.Domain.Services;
using AcademiaFit.Infrastructure.Data.AutoMapper;
using AcademiaFit.Infrastructure.Data.Context;
using AcademiaFit.Infrastructure.Data.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AcademiaFit.UI
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddControllersWithViews()
                .AddNewtonsoftJson()
                .AddRazorRuntimeCompilation();

            services.AddAutoMapper(typeof(Startup));

            services.AddSingleton<AutoMapper.IConfigurationProvider>(AutoMapperConfig.RegisterMappings());
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<AutoMapper.IConfigurationProvider>(), sp.GetService));


            services.AddScoped<ApplicationDbContext>();
            
            services.AddScoped<IAlunoServiceApplication, AlunoServiceApplication>();
            services.AddScoped<IAlunoServiceDomain, AlunoServiceDomain>();
            services.AddScoped<IAlunoRepository, AlunoRepository>();

            services.AddScoped<IProfessorServiceApplication, ProfessorServiceApplication>();
            services.AddScoped<IProfessorServiceDomain, ProfessorServiceDomain>();
            services.AddScoped<IProfessorRepository, ProfessorRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
