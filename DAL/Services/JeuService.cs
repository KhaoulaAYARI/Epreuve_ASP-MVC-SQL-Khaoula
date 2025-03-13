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
    public class JeuService : IJeuRepository<Jeu>
    {

        private const string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database_Epreuve;Integrated Security=True;";
        public void Delete(Guid Jeu_id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Jeu_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(Jeu_id), Jeu_id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Jeu> Get()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Jeu_GetAll";
                    //command.CommandText = "SP_Test";
                    command.CommandType = CommandType.StoredProcedure;
                    
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToJeu();

                        };

                    }
                }
            }
        }

        public Jeu GetById(Guid Jeu_id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Jeu_GetById";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(Jeu_id), Jeu_id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToJeu(); ;
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException(nameof(Jeu_id));
                        }
                    }
                }
            }
        }

        public Guid Insert(Jeu jeu)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Jeu_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nom", jeu.Nom);
                    command.Parameters.AddWithValue("@description", jeu.Description);
                    command.Parameters.AddWithValue("@AgeMin", jeu.AgeMin);
                    command.Parameters.AddWithValue("@AgeMax", jeu.AgeMax);
                    command.Parameters.AddWithValue("@Nombre_Joueur_Min", jeu.Nombre_Joueur_Min);
                    command.Parameters.AddWithValue("@Nombre_Joueur_Max", jeu.Nombre_Joueur_Max);
                    command.Parameters.AddWithValue("@Duree_Minute", jeu.Duree_Minute);
                    command.Parameters.AddWithValue("@Date_Creation", jeu.Date_Creation);
                    command.Parameters.AddWithValue("@utilisateur_id", jeu.Cree_Par ?? (object)DBNull.Value);
                    connection.Open();
                    return (Guid)command.ExecuteScalar();
                }
            }
        }

        public void Update(Guid Jeu_id, Jeu jeu)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Jeu> GetFromUser(Guid utilisateur_id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Jeu_GetByUtilisateurId";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(utilisateur_id), utilisateur_id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToJeu();
                        }
                    }
                }
            }
        }

    }
}
