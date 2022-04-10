using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.Service_Layers
{
    public class SecurityServiceLayer
    {
        private string connectionString;
        private SqlConnection connection;
        public SecurityServiceLayer()
        {
            connectionString = "Server=(local);DataBase=Atm;Integrated Security=SSPI";
            connection = new SqlConnection(connectionString);
        }

        public void AddSecurity(int userId, string pin)
        {
            SqlCommand cmd = new SqlCommand("AddSecurity", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", userId);
            cmd.Parameters.AddWithValue("@pin", pin);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
