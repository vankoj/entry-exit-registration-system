using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entry_Exit_Registration_System
{
    sealed class DatabaseManager : IDisposable
    {
        private static DatabaseManager instance = null;
        private string connectionString;
        private SqlConnection connection;

        public static DatabaseManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseManager();
                }
                return instance;
            }
        }

        private DatabaseManager()
        {
            try
            {
                connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + Path.GetFullPath(Directory.GetCurrentDirectory() + "\\..\\..\\WorkersRegistartion.mdf") + "\";Integrated Security=True";
                connection = new SqlConnection(connectionString);
                connection.Open();

                /* // TODO - Примерна заявка. Изтрий този блок след като напишеш първата заявка
                string query = "SELECT * FROM Position";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MessageBox.Show("Id: " + reader.GetInt32(0) + "\nПозиция: " + reader.GetString(1));
                    }
                }*/
            }
            catch (Exception ex)
            {
                // TODO - За крайния продукт това съобщение няма да се извежда. Оставено е с цел дебъг
                MessageBox.Show(ex.Message);
            }
        }

        public void Dispose()
        {
            connection.Close();
            instance = null;
        }
    }
}
