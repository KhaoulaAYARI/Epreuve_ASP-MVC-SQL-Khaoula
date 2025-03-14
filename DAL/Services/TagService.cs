using DAL.Entities;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure;
using Microsoft.Data.SqlClient;
using System.Data;
using DAL.Mappers;

namespace DAL.Services
{
    public class TagService : ITagRepository<Tag>
    {
        private const string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database_Epreuve;Integrated Security=True;";
        public void Delete(Guid Tag_id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Tag_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(Tag_id), Tag_id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Tag> Get()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Tag_GetAll";
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToTag();

                        };

                    }
                }
            }
        }

        public Tag GetById(Guid Tag_id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Tag_GetById";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(Tag_id), Tag_id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToTag(); ;
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException(nameof(Tag_id));
                        }
                    }
                }
            }
        }

        public IEnumerable<Tag> GetFromJeu(Guid Jeu_id)
        {
            throw new NotImplementedException();
        }

        public Guid Insert(Tag tag)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Tag_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nom", tag.Nom);
                    command.Parameters.AddWithValue("@description", tag.Description ?? (object)DBNull.Value);
                    connection.Open();
                    return (Guid)command.ExecuteScalar();
                }
            }
        }

        public void Update(Guid Tag_id, Tag tag)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Tag_Update";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(Tag_id), Tag_id);
                    command.Parameters.AddWithValue(nameof(Tag.Nom), tag.Nom);
                    command.Parameters.AddWithValue(nameof(Tag.Description), tag.Description);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
