using DAL.Entities;
using DAL.Interfaces;
using DAL.Mappers;
using Microsoft.Data.SqlClient;

namespace DAL.Repositories
{
    public class UserDbRepository : IUserRepository
    {

        private string cs { get; set; } = "Server=localhost\\SQLEXPRESS01;Database=UserDb;Trusted_Connection=True;TrustServerCertificate=True";


        public User Create(User user)
        {
            using(SqlConnection conn = new SqlConnection(cs))
            {
                using(SqlCommand cmd = conn.CreateCommand()) 
                {

                    cmd.CommandText = "INSERT INTO users " +
                        "OUTPUT inserted.id " +
                        "VALUES (@Email,@Name,@Password,@CreationDate,@LastConnection)";
                    cmd.Parameters.AddWithValue("Email", user.Email);
                    cmd.Parameters.AddWithValue("Name", user.Name);
                    cmd.Parameters.AddWithValue("Password", user.Password);
                    cmd.Parameters.AddWithValue("CreationDate", user.CreationDate);
                    cmd.Parameters.AddWithValue("LastConnection", user.LastConnection);

                    conn.Open();

                    user.Id = Convert.ToInt32(cmd.ExecuteScalar());

                    conn.Close();

                    return user;
                }
            }
        }

        public bool Delete(int id)
        {
            using(SqlConnection conn = new SqlConnection(cs))
            {
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Users WHERE Id = @id";

                    cmd.Parameters.AddWithValue("id", id);

                    conn.Open();

                    int result = cmd.ExecuteNonQuery();

                    conn.Close();

                    return result == 1;
                }
            }
        }

        public IEnumerable<User> GetAll()
        {
            using(SqlConnection conn = new SqlConnection(cs))
            {
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Users";

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        yield return reader.ToUser();
                    }

                    conn.Close();
                }
            }
        }

        public User GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Users WHERE id = @id";

                    cmd.Parameters.AddWithValue("id", id);

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    User user = null;

                    while (reader.Read())
                    {
                        user = reader.ToUser();
                    }

                    conn.Close();

                    return user;
                }
            }
        }

        public bool Update(User user)
        {
            using(SqlConnection conn = new SqlConnection(cs))
            {
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Users " +
                        "Set Email = @Email, " +
                        "Name = @Name, " +
                        "Password = @Password, " +
                        "LastConnection = @LastConnection " +
                        "WHERE id = @id";

                    cmd.Parameters.AddWithValue("Email", user.Email);
                    cmd.Parameters.AddWithValue("Name", user.Name);
                    cmd.Parameters.AddWithValue ("Password", user.Password);
                    cmd.Parameters.AddWithValue("LastConnection", user.LastConnection);
                    cmd.Parameters.AddWithValue("id", user.Id);

                    conn.Open();

                    int result = cmd.ExecuteNonQuery();

                    conn.Close();

                    return result == 1;
                }
            }
        }
    }
}
