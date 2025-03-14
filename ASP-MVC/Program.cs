using ASP_MVC.Handlers;
using Common;

namespace ASP_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //
            builder.Services.AddHttpContextAccessor();

            //Ajout de l'appel des services necessaires a l'utilisation de session
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(
                options => {
                    options.Cookie.Name = "CookieEpruve";
                    options.Cookie.HttpOnly = true;
                    options.Cookie.IsEssential = true;
                    options.IdleTimeout = TimeSpan.FromMinutes(10);
                });
            builder.Services.Configure<CookiePolicyOptions>(options => {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
                options.Secure = CookieSecurePolicy.Always;
            });
            //Ajout de notre service de SessionManger
            builder.Services.AddScoped <SessionManager>();


            //Ajout de nos services : ceux de la BLL et ceux de la DAL
            builder.Services.AddScoped<IUtilisateurRepository<BLL.Entities.Utilisateur>,BLL.Services.UtilisateurService>();        builder.Services.AddScoped<IUtilisateurRepository<DAL.Entities.Utilisateur>,DAL.Services.UtilisateurService>();
            builder.Services.AddScoped<IJeuRepository<BLL.Entities.Jeu>, BLL.Services.JeuService>(); builder.Services.AddScoped<IJeuRepository<DAL.Entities.Jeu>, DAL.Services.JeuService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseSession();
            app.UseCookiePolicy();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
