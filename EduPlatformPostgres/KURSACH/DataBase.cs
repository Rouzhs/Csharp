using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace KURSACH
{
    internal class DataBase
    {
        public NpgsqlConnection conn;

        public DataBase() {
            conn = ConnectBD();
        }

        public void Insert(string request)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(request, conn);
                command.Prepare();
                int recordAffected = command.ExecuteNonQuery();
                if (Convert.ToBoolean(recordAffected))
                {
                    MessageBox.Show("Data successfully saved!");
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public bool isEmptyAnswer(NpgsqlDataAdapter adapter)
        {
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return (dt.Rows.Count == 0);
        }

        public DataTable GetData(NpgsqlDataAdapter adapter)
        {
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public NpgsqlDataAdapter Request(string request)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(request, conn);//"select * from users"
            return adapter; 
        }

        public NpgsqlConnection ConnectBD()
        {
            var connectionString = "Host=localhost; Port=5432; Username=postgres; " +
                "Password=12345678; Database=db";
            var conn = new NpgsqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return conn;
        }
    }
}
