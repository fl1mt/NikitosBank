using System;
using System.Data.SQLite;

namespace NikitosBank
{
    class Database
    {
        static string connectionString = "Data Source=UsersDB.db;Version=3;";

        public void InitializeDatabase()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTable = "CREATE TABLE \"Users\" (" +
                    "\"Login\" TEXT NOT NULL UNIQUE," +
                    "\"Password\" TEXT NOT NULL," +
                    "\"FullName\" TEXT NOT NULL," +
                    "\"DepositSum\" REAL," +
                    "\"Months\" INTEGER," +
                    "\"monthlyDeposit\" REAL," +
                    "\"Procent\" TEXT" +
                    ");";

                using (SQLiteCommand command = new SQLiteCommand(createTable, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SQLiteException)
                    {
                    }
                }
            }
        }

        public void AddNewUser(string login, string password, string fullName)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Users (Login, Password, FullName) VALUES (@Login, @Password, @FullName)";

                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@FullName", fullName);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SQLiteException)
                    {
                    }
                }
            }
        }
        public bool isValidLogin(string inputLogin, string inputPassword)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT COUNT(*) FROM Users WHERE Login = @Login AND Password = @Password";
                    command.Parameters.AddWithValue("@Login", inputLogin);
                    command.Parameters.AddWithValue("@Password", inputPassword);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public string GetFullNameByLogin(string inputLogin)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT FullName FROM Users WHERE Login = @Login";
                    command.Parameters.AddWithValue("@Login", inputLogin);

                    object result = command.ExecuteScalar();

                    return result != null ? result.ToString() : null;
                }
            }
        }

        public void InsertDepositData(string inputLogin, double depositSum, int months, double monthlyDeposit, string procent)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "UPDATE Users SET DepositSum = @DepositSum, Months = @Months, " +
                                          "monthlyDeposit = @MonthlyDeposit, Procent = @Procent WHERE Login = @Login";

                    command.Parameters.AddWithValue("@DepositSum", depositSum);
                    command.Parameters.AddWithValue("@Months", months);
                    command.Parameters.AddWithValue("@MonthlyDeposit", monthlyDeposit);
                    command.Parameters.AddWithValue("@Procent", procent);
                    command.Parameters.AddWithValue("@Login", inputLogin);

                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
