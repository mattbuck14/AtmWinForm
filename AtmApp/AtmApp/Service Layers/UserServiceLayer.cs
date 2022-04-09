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

        private int getAge(DateTime bday)
        {
            var today = DateTime.Today;
            var age = today.Year - bday.Year;

            if (bday.Date > today.AddYears(-age)) age--;
            
            return age;
        }

        public void AddUser(string firstName, string lastName, DateTime bday, Form form)
        {
            try 
            { 
                int age = getAge(bday);
                if (age < 18)
                    throw new Exception("You have to be 18 or older to register.");

                SqlCommand cmd = new SqlCommand("AddUser", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fn", firstName);
                cmd.Parameters.AddWithValue("@ln", lastName);
                cmd.Parameters.AddWithValue("@bday", bday);
                cmd.Parameters.AddWithValue("@age", age);
            
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                form.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
