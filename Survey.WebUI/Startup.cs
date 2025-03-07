using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Survey.Business.Abstract;
using Survey.Business.Concrete;
using Survey.DataAccess.Abstract;
using Survey.DataAccess.Concrete.EfCore;
using Survey.DataAccess.Concrete.EfCore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.WebUI
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
            services.AddScoped<IPollService, PollManager>();
            services.AddScoped<IPollDal, EfCorePollDal>();

            services.AddTransient<IUserService, UserManager>();
            services.AddTransient<IUserDal, EfCoreUserDal>();
           

            services.AddTransient<IYesNoQuestionService, YesNoQuestionManager>();
            services.AddTransient<IYesNoQuestionDal, EfCoreYesNoQuetionDal>();

            services.AddTransient<IYesNoAnswerService, YesNoAnswerManager>();
            services.AddScoped<IYesNoAnswerDal, EfCoreYesNoAnswerDAl>();

            services.AddScoped<IUserSurveysService, UserSurveysManager>();
            services.AddScoped<IUserSurveysDal, EfCoreUserSurveysDal>();



            services.AddControllersWithViews();


            services.AddDbContext<TurkcellPollDbContext>(option => option.UseSqlServer(Configuration.GetConnectionString("db"), b => b.MigrationsAssembly("Survey.WebUI")));

            services.AddSession();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(option => {
                    option.LoginPath = "/Account/Login";
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

            app.UseSession();// **
            app.UseAuthentication();
            app.UseAuthorization(); // yetkilendirme

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
