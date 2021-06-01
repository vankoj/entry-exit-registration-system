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

            string query = "SELECT * FROM Employee" +
                           " WHERE EGN LIKE '" + employeeEGN + "'";

            SqlCommand cmd = new SqlCommand(query, connection);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                exists = reader.Read();
            }

            return exists;
        }

        public bool CheckIfAdminExists(string adminId)
        {
            bool exists = false;

            string query = "SELECT * FROM Admin" +
                            " WHERE Id LIKE '" + adminId + "'";

            SqlCommand cmd = new SqlCommand(query, connection);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                exists = reader.Read();
            }

            return exists;
        }

        public bool CheckIfAdminLoginMatch(string username, string password)
        {
            bool matches = false;

            string query = "SELECT * FROM Admin" +
                " WHERE User_Name LIKE @username" +
                " AND Password LIKE @password";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    matches = reader.Read();
                }
            }
            catch (Exception)
            {
                matches = false;
            }

            return matches;
        }

        public List<String> GetPositionNames()
        {
            List<String> result = new List<String>();

            string query = "SELECT Position_Name FROM Position";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(reader.GetString(0));
                    }
                }
            }
            catch (Exception)
            {
                result = null;
            }

            return result;
        }

        public List<CheckInEvent> GetEmployees()
        {
            List<CheckInEvent> result = new List<CheckInEvent>();
            string EGN, firstName, lastName, positionName;

            string query = "SELECT E.EGN, E.F_Name, E.L_Name, P.Position_Name" +
                " FROM Employee E" +
                " JOIN Position P" +
                " ON E.Position_Id = P.Id";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EGN = reader.GetString(0);
                        firstName = reader.GetString(1);
                        lastName = reader.GetString(2);
                        positionName = reader.GetString(3);

                        result.Add(new CheckInEvent(EGN, firstName, lastName, positionName, new DateTime(), false));
                    }
                }
            }
            catch (Exception)
            {
                result = null;
            }

            return result;
        }

        // потребител (назначаване)
        public bool InsertEmployee(string EGN, string firstName, string lastName, string positionName)
        {
            bool successful = true;
            string innerQuery = "SELECT Id FROM Position WHERE Position_Name LIKE @positionName";

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Employee VALUES(@EGN, @firstName, @lastName, (" +
                                                                     innerQuery + "), 'false')", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@EGN", EGN);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@positionName", positionName);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }

        // позиция (добавяне)
        public bool InsertPosition(string positionName)
        {
            bool successful = true;

            string query = "SELECT Position_Name FROM POSITION" +
                " WHERE Position_Name LIKE @positionName";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@positionName", positionName);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        successful = false;
                        return successful;
                    }
                }

                query = "INSERT INTO Position VALUES(@positionName)";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }

        public bool UpdateEmployee(string EGN, string firstName, string lastName, string positionName)
        {
            bool successful = true;
            int positionId;
            string query = "SELECT Id FROM Position WHERE Position_Name LIKE @positionName";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@positionName", positionName);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        positionId = reader.GetInt32(0);
                    }
                    else
                    {
                        return false;
                    }
                }

                cmd.CommandText = "UPDATE Employee" +
                                  " SET F_Name = @firstName, L_Name = @lastName, Position_Id = @positionId" +
                                  " WHERE EGN LIKE @EGN";
                cmd.Parameters.AddWithValue("@EGN", EGN);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@positionId", positionId);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }

        // събитие (чекиране)
        // потребител (влиза/излиза)
        public bool CheckInEmployee(string EGN)
        {
            DateTime today = DateTime.Now;
            bool successful = true;
            bool isInOffice = IsEmployeeInOffice(EGN);

            string query = "INSERT INTO CheckIn VALUES(@EGN, @TODAY, @ISENTRY)";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@EGN", EGN);
                cmd.Parameters.AddWithValue("@TODAY", today);
                cmd.Parameters.AddWithValue("@ISENTRY", !isInOffice);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE Employee SET In_Office = @ISINOFFICE WHERE EGN LIKE @EGN";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@EGN", EGN);
                cmd.Parameters.AddWithValue("@ISINOFFICE", !isInOffice);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }

        public bool IsEmployeeInOffice(string EGN)
        {
            bool isInOffice = false;

            string query = "SELECT In_Office FROM Employee WHERE EGN LIKE @EGN";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@EGN", EGN);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isInOffice = reader.GetBoolean(0);
                    }
                }
            }
            catch (Exception)
            {
                isInOffice = false;
            }

            return isInOffice;
        }

        public string GetEmployeeNames(string EGN)
        {
            string names = null;
            string query = "SELECT F_Name, L_Name FROM Employee WHERE EGN LIKE @EGN";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@EGN", EGN);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        names = reader.GetString(0) + " " + reader.GetString(1);
                    }
                }
            }
            catch (Exception)
            {
                names = null;
            }

            return names;
        }

        // потребител (уволнен)
        public bool RemoveEmployee(string EGN)
        {
            bool successful = true;

            SqlCommand cmd = new SqlCommand("DELETE Employee WHERE EGN LIKE @EGN", connection);

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@EGN", EGN);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }

        // позиция (премахване)
        public bool RemovePosition(string positionName)
        {
            bool successful = true;

            SqlCommand cmd = new SqlCommand("DELETE Position WHERE Position_Name LIKE @positionName", connection);

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@positionName", positionName);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }

        // справка за служител (за ден)
        public List<CheckInEvent> GetEmployeeCheckInsForDate(string EGN, DateTime date)
        {
            List<CheckInEvent> result = new List<CheckInEvent>();

            string firstName, lastName, positionName;
            bool isEntry;
            string query = "SELECT E.EGN, E.F_Name, E.L_Name, P.Position_Name, C.Date_Time, C.Is_Entry" +
              " FROM Employee E" +
              " JOIN Position P" +
              " ON E.Position_Id = P.Id" +
              " JOIN CheckIn C" +
              " ON E.EGN = C.EGN" +
              " WHERE E.EGN = @EGN AND" +
              " DATEPART(yy, C.Date_Time) = @year AND" +
              " DATEPART(mm, C.Date_Time) = @month AND" +
              " DATEPART(dd, C.Date_Time) = @day" +
              " ORDER BY C.Date_Time DESC";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@EGN", EGN);
                cmd.Parameters.AddWithValue("@day", date.Day);
                cmd.Parameters.AddWithValue("@month", date.Month);
                cmd.Parameters.AddWithValue("@year", date.Year);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EGN = reader.GetString(0);
                        firstName = reader.GetString(1);
                        lastName = reader.GetString(2);
                        positionName = reader.GetString(3);
                        date = reader.GetDateTime(4);
                        isEntry = reader.GetBoolean(5);

                        result.Add(new CheckInEvent(EGN, firstName, lastName, positionName, date, isEntry));
                    }
                }
            }
            catch (Exception)
            {
                result = null;
            }

            return result;
        }

        // справка за служител (за месец)
        public List<CheckInEvent> GetEmployeeCheckInsForMonth(string EGN, DateTime date)
        {
            List<CheckInEvent> result = new List<CheckInEvent>();

            string firstName, lastName, positionName;
            bool isEntry;
            string query = "SELECT E.EGN, E.F_Name, E.L_Name, P.Position_Name, C.Date_Time, C.Is_Entry" +
              " FROM Employee E" +
              " JOIN Position P" +
              " ON E.Position_Id = P.Id" +
              " JOIN CheckIn C" +
              " ON E.EGN = C.EGN" +
              " WHERE E.EGN = @EGN AND" +
              " DATEPART(yy, C.Date_Time) = @year AND" +
              " DATEPART(mm, C.Date_Time) = @month" +
              " ORDER BY C.Date_Time DESC";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@EGN", EGN);
                cmd.Parameters.AddWithValue("@month", date.Month);
                cmd.Parameters.AddWithValue("@year", date.Year);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EGN = reader.GetString(0);
                        firstName = reader.GetString(1);
                        lastName = reader.GetString(2);
                        positionName = reader.GetString(3);
                        date = reader.GetDateTime(4);
                        isEntry = reader.GetBoolean(5);

                        result.Add(new CheckInEvent(EGN, firstName, lastName, positionName, date, isEntry));
                    }
                }
            }
            catch (Exception)
            {
                result = null;
            }

            return result;
        }

        // справка за служител (за период)
        public List<CheckInEvent> GetEmployeeCheckInsForPeriod(string EGN, DateTime dateStart, DateTime dateEnd)
        {
            List<CheckInEvent> result = new List<CheckInEvent>();

            string firstName, lastName, positionName;
            bool isEntry;
            DateTime date;

            string query = "SELECT E.EGN, E.F_Name, E.L_Name, P.Position_Name, C.Date_Time, C.Is_Entry" +
              " FROM Employee E" +
              " JOIN Position P" +
              " ON E.Position_Id = P.Id" +
              " JOIN CheckIn C" +
              " ON E.EGN = C.EGN" +
              " WHERE E.EGN = @EGN AND" +
              " C.Date_Time BETWEEN @dateStart AND @dateEnd" +
              " ORDER BY C.Date_Time DESC";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@EGN", EGN);
                cmd.Parameters.AddWithValue("@dateStart", dateStart);
                cmd.Parameters.AddWithValue("@dateEnd", dateEnd);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EGN = reader.GetString(0);
                        firstName = reader.GetString(1);
                        lastName = reader.GetString(2);
                        positionName = reader.GetString(3);
                        date = reader.GetDateTime(4);
                        isEntry = reader.GetBoolean(5);

                        result.Add(new CheckInEvent(EGN, firstName, lastName, positionName, date, isEntry));
                    }
                }
            }
            catch (Exception)
            {
                result = null;
            }

            return result;
        }

        // справка за всички служители (за период)
        public List<CheckInEvent> GetEmployeesForPeriod(DateTime dateStart, DateTime dateEnd)
        {
            List<CheckInEvent> result = new List<CheckInEvent>();


            string EGN, firstName, lastName, positionName;
            bool isEntry;
            DateTime date;

            string query = "SELECT E.EGN, E.F_Name, E.L_Name, P.Position_Name, C.Date_Time, C.Is_Entry" +
              " FROM Employee E" +
              " JOIN Position P" +
              " ON E.Position_Id = P.Id" +
              " JOIN CheckIn C" +
              " ON E.EGN = C.EGN" +
              " WHERE C.Date_Time" +
              " BETWEEN @dateStart AND @dateEnd" +
              " ORDER BY C.Date_Time DESC";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@dateStart", dateStart);
                cmd.Parameters.AddWithValue("@dateEnd", dateEnd);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EGN = reader.GetString(0);
                        firstName = reader.GetString(1);
                        lastName = reader.GetString(2);
                        positionName = reader.GetString(3);
                        date = reader.GetDateTime(4);
                        isEntry = reader.GetBoolean(5);

                        result.Add(new CheckInEvent(EGN, firstName, lastName, positionName, date, isEntry));
                    }
                }
            }
            catch (Exception)
            {
                result = null;
            }

            return result;
        }
    }
}
