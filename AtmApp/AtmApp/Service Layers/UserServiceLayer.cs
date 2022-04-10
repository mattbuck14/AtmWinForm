using AtmApp.Models;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AtmApp.Service_Layers
{
    public class UserServiceLayer
    {
        private string connectionString;
        private SqlConnection connection;
        public UserServiceLayer()
        {
            connectionString = "Server=(local);DataBase=Atm;Integrated Security=SSPI";
            connection = new SqlConnection(connectionString);
        }

        public void AddUser(string firstName, string lastName, DateTime bday, int age)
        {
            SqlCommand cmd = new SqlCommand("AddUser", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fn", firstName);
            cmd.Parameters.AddWithValue("@ln", lastName);
            cmd.Parameters.AddWithValue("@bday", bday);
            cmd.Parameters.AddWithValue("@age", age);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public int GetCreatedUserId()
        {
            string query = "SELECT TOP 1 UserId FROM Atm.dbo.Users ORDER BY UserId DESC";
            SqlCommand cmd = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id = reader.GetInt32(0);
            reader.Close();
            connection.Close();
            return id;
        }
    }
}
