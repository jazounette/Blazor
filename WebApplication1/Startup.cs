using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1 {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
            services.AddRazorPages();
            services.AddServerSideBlazor();     // necessaire au fonctionnement de la partie serveur de blazor
            services.AddSingleton<WeatherForecastService>();    //une seule instance pour le service, pour éviter les conflits
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment())   {      app.UseDeveloperExceptionPage();     }
            else  {   app.UseExceptionHandler("/Error");    }

            app.UseStaticFiles();       //permet l'utilisation de fichiers statics (les ressources de type image, css...)

            app.UseRouting();           //le service de routing

            app.UseEndpoints(endpoints =>  {
                endpoints.MapBlazorHub();                   //SignalR (lien entre le serveur et le dom]
                endpoints.MapFallbackToPage("/_Host");      //permet l'accès aux pages du site
            });
        }
    }
}
