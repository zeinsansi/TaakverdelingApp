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

        public void TaakToevoegen(Taak taak , int persoonId , int groepId)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Taak VALUES(@naam , @beshrijving , @deadline , @persoonId , @groepId)", this.connection);
            command.Parameters.AddWithValue("naam", taak.GetNaam());
            command.Parameters.AddWithValue("@beshrijving", taak.GetBeschrijving());
            command.Parameters.AddWithValue("@deadline", taak.GetDeadLine());
            command.Parameters.AddWithValue("@persoonId", persoonId);
            command.Parameters.AddWithValue("@groepId", groepId);
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public DataTable GetTaken(int persoonId , int groepId)
        {
            OpenConnection();
            string query = @"SELECT * FROM Taak 
                 WHERE persoonId = @persoonId AND groepId = @groepId";
            using (SqlCommand command = new(query, this.connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@persoonId" , persoonId);
                command.Parameters.AddWithValue("@groepId" , groepId);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;

            }
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


        public void TaakVerwijderen(int taakId)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("DELETE FROM Taak WHERE Id = @taakId", this.connection);
            command.Parameters.AddWithValue("@taakId", taakId);
            command.ExecuteNonQuery();
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
/*        public List<Groep> GetGroepn(int id)
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
        }*/
        public DataTable GetGroepen()
        {
            OpenConnection();
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Groep", this.connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;

            }
        }
        public Groep GroepWeergeven(int id)
        {
            Groep groep = null;
            OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM Groep WHERE Id = @id", this.connection);
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    groep = new Groep(
                        dr["Naam"].ToString(),
                        dr["ProjectNaam"].ToString(),
                        dr["ProjectBeshrijving"].ToString());
                }
            }
            CloseConnection();
            return groep;
        }
        public void GroepVerwijderen(int Id)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("DELETE FROM Groep WHERE Id = @Id", this.connection);
            command.Parameters.AddWithValue("@Id", Id);
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public DataTable GetGroepleden(int id)
        {
            OpenConnection();
            string query = @"SELECT * FROM Persoon 
                 INNER JOIN GroepPersoon on Persoon.Id = GroepPersoon.persoonId
                 WHERE GroepPersoon.groepId = @id";
            using (SqlCommand command = new(query, this.connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))

            {
                command.Parameters.AddWithValue("id", id);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

    }

}
