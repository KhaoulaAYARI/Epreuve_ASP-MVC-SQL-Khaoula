using DAL.Entities;
using DAL.Services;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
           UtilisateurService service = new UtilisateurService();

            /*-------------TEST DAL-------------
             * ---------------------------------
             * Test INSERT (DAL) OK12-02-2025
             * Utilisateur u = new Utilisateur()
            {

                Utilisateur_Id = Guid.NewGuid(), // Génère un nouvel identifiant unique
                Email = "Maria@example.com",
                Password = "Test1234=",
                Pseudo = "Maria",
                Date_Creation = DateTime.Now,
                Date_Desactivation = null

            };
            service.Insert(u);
            Console.WriteLine($"Utilisateur inséré avec succès. ID : {u.Utilisateur_Id}{u.Pseudo}");*/

            /* Test GET (DAL) pas ok
             * foreach (Utilisateur u in service.Get())
             {
                 Console.WriteLine($"Pseudo: {u.Pseudo} ");
             }*/

            /*Test GetById (DAL) OK12-02-2025
             * Guid id = Guid.Parse("bac85a9a-ba8e-4ee4-8223-20970283df03");
            Utilisateur u =service.GetById(id);
            Console.WriteLine(u.Pseudo); */

            /*Test Update (DAL) ok12-03-2025
            
            
            Utilisateur u = new Utilisateur()
            {

                Utilisateur_Id = Guid.NewGuid(), // Génère un nouvel identifiant unique
                Email = "Sonia@example.com",
                Password = "Test1234=",
                Pseudo = "Sonia",
                Date_Creation = DateTime.Now,
                Date_Desactivation = null

            };
            service.Insert(u);
            Console.WriteLine("avant update");
            Console.WriteLine($"{ u.Utilisateur_Id}--{u.Pseudo }");
            u.Pseudo = "Rony";
            service.Update( u.Utilisateur_Id,u);
            Console.WriteLine("apres update");
            Console.WriteLine($"{u.Utilisateur_Id}--{u.Pseudo}"); */





        }
    }
}
