using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.Service_Layers
{
    public class AccountServiceLayer
    {
        private string connectionString;
        private SqlConnection connection;
        public AccountServiceLayer()
        {
            connectionString = "Server=(local);DataBase=Atm;Integrated Security=SSPI";
            connection = new SqlConnection(connectionString);
        }

        public void AddAccount(int routingNum, int userId)
        {
            SqlCommand cmd = new SqlCommand("AddAccount", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@routing", routingNum);
            cmd.Parameters.AddWithValue("@cash", 0);
            cmd.Parameters.AddWithValue("@opened", DateTime.Today);
            cmd.Parameters.AddWithValue("@id", userId);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public object[] RetrieveAccount(int AccountNumber)
        {
            SqlCommand cmd = new SqlCommand("RetrieveAccount", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accountNum", AccountNumber);

            SqlDataReader reader = cmd.ExecuteReader();
            connection.Open();
            reader.Read();
            object[] accountInfo = new object[] {};
            reader.GetValues(accountInfo);
            reader.Close();
            connection.Close();
            return accountInfo;
            
        }
    }
}
