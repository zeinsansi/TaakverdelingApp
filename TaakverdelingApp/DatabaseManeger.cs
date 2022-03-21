using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TaakVerdelingLibrary;

namespace TaakverdelingApp
{
    internal class DatabaseManeger
    {
        private static string connectionString = @"Server=mssqlstud.fhict.local;Database=dbi490959;User Id=dbi490959;Password=welkom123;";
        private SqlConnection connection;
        public string taakId;


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

/*        public void TestToevoegen(string naam )
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Persoon VALUES(@naam)", this.connection);
            command.Parameters.AddWithValue("@naam",naam);
            command.ExecuteNonQuery();
            CloseConnection();
        }*/

        public void TaakToevoegen(Taak taak)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Taak VALUES(@naam , @beshrijving , @deadline)", this.connection);
            command.Parameters.AddWithValue("naam", taak.GetNaam());
            command.Parameters.AddWithValue("@beshrijving", taak.GetBeschrijving());
            command.Parameters.AddWithValue("@deadline", taak.GetDeadLine());
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public Taak TaakWeergeven(int id)
        {
            Taak taak = null;
            OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM Taak WHERE Id = @id", this.connection);
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader dr =command.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    taak = new Taak(
                        dr["Naam"].ToString(),
                        dr["Beschrijving"].ToString(),
                        Convert.ToDateTime(dr["Deadline"]));
                }
            }
            CloseConnection();
            return taak;
        }

        public DataTable HaalGegevensOp()
        {
            OpenConnection();
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Taak", this.connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;

            }
        }

        public void TaakVerwijderen(int taakId)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("DELETE FROM Taak WHERE Id = @taakId", this.connection);
            command.Parameters.AddWithValue("@taakId", taakId);
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public void GetTaakID()
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("SELECT Id FROM Taak", this.connection);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                while (dr.Read())
                {
                    taakId = dr["Id"].ToString();
                }
            }
            CloseConnection();
        }

        public void GroepMaken(Groep groep)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Groep VALUES(@naam , @projectNaam, @projectBeshrijving)", this.connection);
            command.Parameters.AddWithValue("naam", groep.GetNaam());
            command.Parameters.AddWithValue("@projectNaam", groep.GetProjectNaam());
            command.Parameters.AddWithValue("@projectBeshrijving", groep.GetProjectBeschrijving());
            command.ExecuteNonQuery();
            CloseConnection();
        }
        public List<Groep> GetGroepn()
        {
            List<Groep> mijnGroepen = new List<Groep>();
            OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM Groep", this.connection);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    mijnGroepen.Add(new Groep(
                        dr["Naam"].ToString(),
                        dr["ProjectNaam"].ToString(),
                        dr["ProjectNaam"].ToString()));
                }
            }
            CloseConnection();
            return mijnGroepen;
        }
    }

}
