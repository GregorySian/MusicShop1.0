
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using MusicHub.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MusicHub.Models;
using MusicHub.Models.Cart;
using Microsoft.AspNetCore.Http;
using MusicHub.Services;
using MusicHub.Interfaces;
using MusicHub.Models.Order;
using System;
using MusicHub.Infrastructure;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Localization;
using System.Collections.Generic;

namespace MusicHub
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
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddTransient<IAlbumRepository, EFAlbumRepository>();
            services.AddTransient<IOrderRepository, EFOrderRepository>();
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddScoped<Wishlist>(wl => SessionWishlist.GetWishlist(wl));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllersWithViews();
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddMvc(options => options.EnableEndpointRouting = false);

            services.AddRazorPages();

                services.AddDistributedMemoryCache();
                services.AddMemoryCache();
                services.AddSession(options =>
                {
                    options.IdleTimeout = TimeSpan.FromMinutes(10);
                    options.Cookie.HttpOnly = true;
                    options.Cookie.IsEssential = true;
                });


            services.AddAuthentication()
                    .AddFacebook(facebookOptions =>
                    {
                        facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                        facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
                    });
                    //.AddMicrosoftAccount(microsoftOptions =>
                    //{
                    //    microsoftOptions.ClientId = Configuration["Authentication:Microsoft:ClientId"];
                    //    microsoftOptions.ClientSecret = Configuration["Authentication:Microsoft:ClientSecret"];
                    //});
            services.AddApplicationInsightsTelemetry();


        }
           

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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
            app.UseSession();


            var defaultCulture = new CultureInfo("el-GR");
            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(defaultCulture),
                SupportedCultures = new List<CultureInfo> { defaultCulture },
                SupportedUICultures = new List<CultureInfo> { defaultCulture }
            };
            app.UseRequestLocalization(localizationOptions);





            //app.UseMvc(routes =>
            //    {

            //        routes.MapRoute(
            //            name: null,
            //            template: "{genre}/Page{productPage:int}",
            //            defaults: new { Controller = "Product", action = "List" });

            //        routes.MapRoute(
            //            name: null,
            //            template: "{genre}/Page{productPage:int}",
            //            defaults: new
            //            {
            //                Controller = "Product",
            //                action = "List"
            //            });

            //        routes.MapRoute(
            //            name: null,
            //            template: "Page{productPage:int}",
            //            defaults: new
            //            {
            //                Controller = "Product",
            //                action = "List"
            //                ,
            //                productPage = 1
            //            });

            //        routes.MapRoute(
            //           name: null,
            //           template: "{genre}",
            //           defaults: new
            //           {
            //               controller = "Product",
            //               action = "List",
            //               productPage = 1
            //           });
            //        routes.MapRoute(
            //           name: null,
            //           template: "",
            //           defaults: new
            //           {
            //               controller = "Product",
            //               action = "List",
            //               productPage = 1
            //           });
            //        routes.MapRoute(
            //            name: "your_wishlist",
            //            template: "",
                       

            //        routes.MapRoute(name: null, template: "{controller}/{action}/{id?}"));
            //    });


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
