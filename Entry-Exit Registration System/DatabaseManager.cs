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

                /* // TODO - Примерна заявка. Изтрий този блок след като заявките са написани
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

        public bool CheckIfEmployeeExists(string employeeEGN)
        {
            bool exists = false;

            string query = "SELECT * FROM Employee\n" +
                            "WHERE EGN LIKE '" + employeeEGN + "'";

            SqlCommand cmd = new SqlCommand(query, connection);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                exists = reader.Read();
            }

            return exists;
        }

        public List<String> getPositionNames()
        {
            List<String> result = new List<String>();

            string query = "SELECT Position_Name FROM Position";

            SqlCommand cmd = new SqlCommand(query, connection);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    result.Add(reader.GetString(0));
                }
            }

            return result;
        }

        // потребител (назначаване)
        public bool InsertEmployee(string EGN, string firstName, string lastName, int positionId)
        {
            bool successful = false;


            SqlCommand cmd = new SqlCommand("INSERT INTO Employee VALUES(@EGN, @firstName," +
                                                                   "@lastName, @positionId" + false + ")", connection);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@EGN", EGN);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@positionId", positionId);

            cmd.Connection = connection;
            cmd.ExecuteNonQuery();



            return successful;
        }

        // позиция (добавяне)
        public bool InsertPosition(string positionName)
        {
            bool successful = false;

            SqlCommand cmd = new SqlCommand("INSERT INTO Position VALUES(@positionName)", connection);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@positionName", positionName);

            cmd.Connection = connection;
            cmd.ExecuteNonQuery();


            return successful;
        }

        // събитие (чекиране)
        // потребител (влиза/излиза)
        // TODO: провери формат на датата
        public bool CheckInEmployee(string EGN)
        {
            DateTime today = DateTime.Today;
            bool successful = false;
            bool isInOfice = false;


            string query = "SELECT in_Office FROM Employee WHERE EGN LIKE @EGN";
            SqlCommand cmd = new SqlCommand(query, connection);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    isInOfice = reader.GetBoolean(0);
                }
                else
                {
                    return false;
                }
            }


            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@EGN", EGN);


            cmd.Connection = connection;
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand("INSERT INTO Checkln VALUES(@EGN, @TODAY, @ISINOFICE)", connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@EGN", EGN);
            cmd.Parameters.AddWithValue("@TODAY", today);
            cmd.Parameters.AddWithValue("@ISINOFICE", !isInOfice);


            cmd.Connection = connection;
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("UPDATE Employee SET ISINOFICE = @ISINOFICE", connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ISINOFICE", !isInOfice);


            cmd.Connection = connection;
            cmd.ExecuteNonQuery();


            return successful;
        }

        // потребител (уволнен)
        public bool RemoveEmployee(string EGN)
        {
            bool successful = false;

            SqlCommand cmd = new SqlCommand("DELETE Employee WHERE EGN LIKE @EGN", connection);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@EGN", EGN);

            cmd.Connection = connection;
            cmd.ExecuteNonQuery();



            return successful;
        }

        // позиция (премахване)
        public bool RemovePosition(string positionName)
        {
            bool successful = false;

            SqlCommand cmd = new SqlCommand("DELETE Position WHERE Position_Name LIKE @positionName", connection);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@positionName", positionName);

            cmd.Connection = connection;
            cmd.ExecuteNonQuery();


            return successful;
        }

        // справка за служител (за ден)
        public List<CheckInEvent> GetEmployeeCheckInsForDate(string EGN, DateTime date) // TODO - смени типа на връщаните данни (резултат от заявката) (List?)
        {
            List<CheckInEvent> result = new List<CheckInEvent>();
            string query = "SELECT * FROM Employee";

            // Добавяне на примерен запис към колекцията с резултатите
            result.Add(new CheckInEvent("991111222222", "Петър", "Драганов", "разработчик", new DateTime(2010, 12, 1, 12, 21, 31), true));

            // TODO - тяло на метода

            //date.Day;
            //date.Month;
            //date.Year;

            return result;
        }

        // справка за служител (за месец)
        public List<CheckInEvent> GetEmployeeCheckInsForMonth(string EGN, DateTime date)
        {
            List<CheckInEvent> result = new List<CheckInEvent>();

            // TODO - тяло на метода

            //date.Month;
            //date.Year;

            return result;
        }

        // справка за служител (за период)
        public List<CheckInEvent> GetEmployeeCheckInsForPeriod(string EGN, DateTime dateStart, DateTime dateEnd)
        {
            List<CheckInEvent> result = new List<CheckInEvent>();

            // TODO - тяло на метода

            //dateStart.Day;
            //dateStart.Month;
            //dateStart.Year;
            //dateEnd.Day;
            //dateEnd.Month;
            //dateEnd.Year;

            return result;
        }

        // справка за всички служители (за период)
        public List<CheckInEvent> GetEmployeesForPeriod(DateTime dateStart, DateTime dateEnd)
        {
            List<CheckInEvent> result = new List<CheckInEvent>();

            // TODO - тяло на метода

            //dateStart.Day;
            //dateStart.Month;
            //dateStart.Year;
            //dateEnd.Day;
            //dateEnd.Month;
            //dateEnd.Year;

            return result;
        }
    }
}
