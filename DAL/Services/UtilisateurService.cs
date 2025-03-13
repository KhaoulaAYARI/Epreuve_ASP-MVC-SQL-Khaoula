using Common;
using DAL.Entities;
using DAL.Mappers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class UtilisateurService:IUtilisateurRepository<Utilisateur>
    {
        private const string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database_Epreuve;Integrated Security=True;";
        public IEnumerable<Utilisateur> Get()
        {
            using (SqlConnection connection=new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Utilisateur_GetAllActive";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToUtilisateur();
                            
                        };
                        
                    }
                }
            }
        }

        public Utilisateur GetById(Guid Utilisateur_id) 
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "PS_Utilisateur_GetById";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(Utilisateur_id), Utilisateur_id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToUtilisateur();
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException(nameof(Utilisateur_id));
                        }
                    }
                }
            }
        }

        public Guid Insert(Utilisateur utilisateur)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Utilisateur_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(utilisateur.Email), utilisateur.Email);
                    command.Parameters.AddWithValue(nameof(utilisateur.Password), utilisateur.Password);
                    command.Parameters.AddWithValue(nameof(utilisateur.Pseudo), utilisateur.Pseudo);
                    connection.Open();
                    return(Guid)command.ExecuteScalar();
                }
            }
        }

        public void Update(Guid Utilisateur_id, Utilisateur utilisateur)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Utilisateur_Update";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(Utilisateur_id), Utilisateur_id);
                    command.Parameters.AddWithValue(nameof(Utilisateur.Email), utilisateur.Email);
                    command.Parameters.AddWithValue(nameof(Utilisateur.Pseudo),utilisateur.Pseudo );
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public Guid CheckPassword(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_User_CheckPassword";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(email), email);
                    command.Parameters.AddWithValue(nameof(password), password);
                    connection.Open();
                    return(Guid)command.ExecuteScalar();

                }
            }
        }
    }
}
