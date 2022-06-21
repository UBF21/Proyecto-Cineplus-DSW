using Cineplus_DSW_Proyecto.Repository.IModel;
using Cineplus_DSW_Proyecto.Repository.Implents;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cineplus_DSW_Proyecto
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
            services.AddControllersWithViews();
            services.AddSingleton<ICliente,ClienteRepository>();
            services.AddSingleton<IComestible,ComestibleRepository>();
            services.AddSingleton<ITipoComestible, TipoComestibleRepository>();
            services.AddSingleton<ITipoProveedor, TipoProveedorRepository>();
            services.AddSingleton<IPelicula, PeliculaRepository>();
            services.AddSingleton<ITipoPelicula, TipoPeliculaRepository>();
            services.AddSingleton<IProveedor, ProveedorRepository>();
            services.AddSingleton<ITipoProveedor, TipoProveedorRepository>();
            services.AddSingleton<IUsuario, UsuarioRepository>();
            services.AddSingleton<ITipoUsuario, TipoUsuarioRepository>();
            services.AddSingleton<IBoleta,BoletaRepository>();
            services.AddSingleton<ILogin,LoginRepository>();
            services.AddSingleton<IClienteGraphic,ClienteGraphicRepository>();
            services.AddSingleton<IUsuarioGraphic,UsuarioGraphicRepository>();
            services.AddSingleton<IPeliculaGraphic, PeliculaGraphicRepository>();
            services.AddSingleton<IComestibleGraphic,ComestibleGraphicRepository>();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(option =>
                {
                    option.LoginPath = "/Login/login";
                    option.ExpireTimeSpan = TimeSpan.FromMinutes(20);
                });

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

            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=login}/{id?}");
            });

            Rotativa.AspNetCore.RotativaConfiguration.Setup(env.WebRootPath, "../Rotativa");
        }
    }
}
