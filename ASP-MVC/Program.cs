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
            //Ajout de nos services : ceux de la BLL et ceux de la DAL
            builder.Services.AddScoped<IUtilisateurRepository<BLL.Entities.Utilisateur>,BLL.Services.UtilisateurService>();        builder.Services.AddScoped<IUtilisateurRepository<DAL.Entities.Utilisateur>,DAL.Services.UtilisateurService>();
            builder.Services.AddScoped<IJeuRepository<BLL.Entities.Jeu>, BLL.Services.JeuService>(); builder.Services.AddScoped<IJeuRepository<DAL.Entities.Jeu>, DAL.Services.JeuService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
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
