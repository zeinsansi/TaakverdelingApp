using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TaakverdelingApp
{
    internal class DatabaseManeger
    {
        private static string connectionString = @"Server=mssqlstud.fhict.local;Database=dbi490959;User Id=dbi490959;Password=welkom123;";
        private SqlConnection connection;


        private void OpenConnection()
        {
            try
            {
                this.connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch { return; }
        }

        private void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch { return; }
        }

        public void TestToevoegen(string naam )
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Persoon VALUES(@naam)", this.connection);
            command.Parameters.AddWithValue("@naam",naam);
            command.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
