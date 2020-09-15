using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using EvaCoreWeb.Data;
using EvaCoreWeb.Models;
using EvaCoreWeb.Services;
using System.Globalization;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

namespace EvaCoreWeb
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<EvaCoreWebContext>(options =>
            options.UseMySql(Configuration.GetConnectionString("EvaCoreWebContext"), builder =>
                builder.MigrationsAssembly("EvaCoreWeb")));

            services.AddScoped<SeedingService>(); 
            services.AddScoped<CodigoService>(); 
            services.AddScoped<GrupoService>(); 
            services.AddScoped<SubGrupoService>(); 
            services.AddScoped<UnidadeMedidaEstoqueService>(); 
            services.AddScoped<ReceitaService>(); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, SeedingService seedingService)
        {
            //configura o padrao de uso do sistema para datas, numeros, etc
            var enBR = new CultureInfo("en-US");
            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(enBR),
                SupportedCultures = new List<CultureInfo> { enBR },
                SupportedUICultures = new List<CultureInfo> { enBR }
            };

            app.UseRequestLocalization(localizationOptions);
            //ate aqui

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                seedingService.Seed(); //popula a base de dados de acordo oom os dados cadastrados no arquivo SeedingService
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
