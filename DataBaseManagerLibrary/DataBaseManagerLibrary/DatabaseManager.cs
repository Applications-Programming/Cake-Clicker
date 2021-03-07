using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace DataBaseManager
{
    public class DatabaseManager
    {

        SqlConnection _connection;
        ConnectionInfo _connectionInfo;
        Action<string> DisplayError;


        /// <summary>
        /// Creates a DatabaseManager with a connection to the database provided
        /// </summary>
        /// <param name="dataSource">the database source (server/local)</param>
        /// <param name="database">the name of the database</param>
        /// <param name="UserId">SQL login ID</param>
        /// <param name="password">SQL login password</param>
        /// <returns>The created Database or null if connection failed</returns>
        public static DatabaseManager CreateDatabaseManager(ConnectionInfo connectionInfo, Action<string> displayError)
        {
            Console.WriteLine("Getting Database Connection:");

            //your connection string 

            string connString = @"Data Source=" + connectionInfo._dataSource + ";Initial Catalog="
                        + connectionInfo._database + ";Persist Security Info=True;User ID=" + connectionInfo._userId + ";Password=" + connectionInfo._password;

            /*string connString = @"Data Source=" + connectionInfo._dataSource + ";Initial Catalog="
                        + connectionInfo._database + ";Persist Security Info=False;User ID=" + connectionInfo._userId + ";Password=" + connectionInfo._password
                        + "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";*/

            //create instanace of database connection
            SqlConnection connection = new SqlConnection(connString);


            try
            {
                //open connection
                connection.Open();
                Console.WriteLine("Connection successful!\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message + "\n");
                displayError("Server not detected - enabling offline mode");
                return null;
            }
            Console.Out.Flush();
            connection.Close();
            return new DatabaseManager(connection, connectionInfo, displayError);
        }

        /// <summary>
        /// Constructor that takes in an existing connection
        /// </summary>
        DatabaseManager(SqlConnection connection, ConnectionInfo connectionInfo, Action<string> displayError)
        {
            _connection = connection;
            _connectionInfo = connectionInfo;
            DisplayError = displayError;
        }

        /// <summary>
        /// Desposes of _connection
        /// </summary>
        ~DatabaseManager()
        {
            _connection.Dispose();
        }


        /// <summary>
        /// Sets the DatabaseManager Connection
        /// </summary>
        /// <param name="connection"></param>
        private void SetConnection(SqlConnection connection) { _connection = connection; }


        /// <summary>
        /// Saves given info to the database
        /// </summary>
        /// <param name="id"> -1 -> add as new user</param>
        /// <param name="name"></param>
        /// <param name="ammountOfCake"></param>
        /// <param name="upgrades"></param>
        /// <param name="newUser">true -> add as new user (regardless of id)</param>
        /// <returns>the user ID/ -1 if connection fails</returns>
        public int SaveToDatabase(int id, string name, int ammountOfCake, int[] upgrades, bool newUser = false)
        {
            try
            {
                _connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message + "\n");
                DisplayError("Couldn't Load Database.\n" +
                                "Check Log for more info");
                return -1;
            }

            if (newUser == true || id == -1)
            {
                StringBuilder strBuilder = new StringBuilder();
                strBuilder.Append("INSERT INTO Users (Name, CakeAmount, Upgrades) output INSERTED.ID VALUES ");
                strBuilder.Append("(N'" + name + "', N'" + ammountOfCake + "', N'");
                if(upgrades != null)
                {
                    foreach (int i in upgrades)
                    {
                        strBuilder.Append(i.ToString() + " ");
                    }
                }
                else
                {
                    strBuilder.Append("0 0 0 0 0 0 0");
                }
                strBuilder.Append("') ");

                string sqlQuery = strBuilder.ToString();
                using (SqlCommand command = new SqlCommand(sqlQuery, _connection))
                {
                    
                    id = (int)command.ExecuteScalar();
                    Console.WriteLine("\nQuery Executed - Saved Game to " + _connectionInfo._database);
                }
            }
            else
            {
                StringBuilder strBuilder = new StringBuilder();
                strBuilder.Append("UPDATE Users\n" +
                    "SET Name = '" + name + "', CakeAmount = " + ammountOfCake + ", Upgrades = '");
                if (upgrades != null)
                {
                    foreach (int i in upgrades)
                    {
                        strBuilder.Append(i.ToString() + " ");
                    }
                }
                else
                {
                    strBuilder.Append("0 0 0 0 0 0 0");
                }
                strBuilder.Append("'\n" +
                    "WHERE ID = " + id);

                string sqlQuery = strBuilder.ToString();
                using (SqlCommand command = new SqlCommand(sqlQuery, _connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("\nQuery Executed - Saved Game to " + _connectionInfo._database);
                }
            }
            _connection.Close();
            return id;
        }

        /// <summary>
        /// Saves GameData to the database
        /// </summary>
        /// <param name="gameData"></param>
        /// <param name="newUser"></param>
        /// <returns>the user ID/ -1 if connection fails</returns>
        public int SaveToDatabase(GameData gameData, bool newUser = false)
        {
            int id = gameData.Id;
            string Name = gameData.PlayerName;
            int ammountOfCake = gameData.amountOfCake;
            int[] upgrades = gameData.upgradeCount;

            return SaveToDatabase(id, Name, ammountOfCake, upgrades);
        }

        /// <summary>
        /// Gets the GameData of the specified Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>null if connection fails</returns>
        public GameData GetUserInfo(int id)
        {
            try
            {
                _connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message + "\n");
                DisplayError("Couldn't Load Database.\n" +
                                "Check Log for more info");
                return null;
            }

            GameData game = new GameData();
            SqlDataReader reader;

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("SELECT * FROM dbo.Users\n");
            strBuilder.Append("WHERE ID=" + id);


            string sqlQuery = strBuilder.ToString();
            using (SqlCommand command = new SqlCommand(sqlQuery, _connection))
            {
                command.ExecuteNonQuery();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    game.Id = (int)reader[0];
                    game.PlayerName = reader[1].ToString().Trim();
                    game.amountOfCake = (int)reader[2];
                    string[] upgrades = reader[3].ToString().Trim().Split(' ');
                    for (int i = 0; i < upgrades.Length; i++)
                    {
                        game.upgradeCount[i] = int.Parse(upgrades[i]);
                    }
                    Console.WriteLine("\nQuery Executed - Retrieved User" + _connectionInfo._database);
                }
                else 
                { 
                    reader.Close();
                    Console.WriteLine("\nQuery Executed - UserID: " + id + " does not exist.");
                    DisplayError("User does not exist");
                }
                
                
            }
            _connection.Close();
            return game;
        }      

        public ConnectionInfo GetConnectionInfo() { return _connectionInfo; }

        //Database Clear should be done manually

        

        public List<GameData> GetScoresAbove(int score)
        {
            try
            {
                _connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message + "\n");
                DisplayError("Couldn't Load Database.\n" +
                                "Check Log for more info");
                return null;
            }

            List<GameData> users = new List<GameData>();
            SqlDataReader reader;

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("SELECT * FROM dbo.ScoreBoard\n");
            strBuilder.Append("WHERE CakeScore >=" + score);


            string sqlQuery = strBuilder.ToString();
            using (SqlCommand command = new SqlCommand(sqlQuery, _connection))
            {
                command.ExecuteNonQuery();
                reader = command.ExecuteReader();

                int index = 0;
                while (reader.Read())
                {
                    users[index] = new GameData();

                    users[index].Id = (int)reader[0];
                    users[index].PlayerName = reader[1].ToString().Trim();
                    users[index].amountOfCake = (int)reader[2];
                    string[] upgrades = reader[3].ToString().Trim().Split(' ');
                    for (int i = 0; i < upgrades.Length; i++)
                    {
                        users[index].upgradeCount[i] = int.Parse(upgrades[i]);
                    }
                    Console.WriteLine("\nQuery Executed - Retrieved User" + _connectionInfo._database);

                    index++;
                }
            }
            _connection.Close();
            return users;
        }

        public List<GameData> GetHighScores(int count)
        {
            try
            {
                _connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message + "\n");
                DisplayError("Couldn't Load Database.\n" +
                                "Check Log for more info");
                return null;
            }

            List<GameData> users = new List<GameData>();
            SqlDataReader reader;

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("SELECT * FROM dbo.Users\n");
            strBuilder.Append("ORDER BY CakeAmount DESC, ID;");


            string sqlQuery = strBuilder.ToString();
            using (SqlCommand command = new SqlCommand(sqlQuery, _connection))
            {
                //command.ExecuteNonQuery();
                reader = command.ExecuteReader();

                int index = 0;
                while (reader.Read())
                {
                    if (index >= count)
                        break;

                    GameData user = new GameData();

                    user.Id = (int)reader[0];
                    user.PlayerName = reader[1].ToString().Trim();
                    user.amountOfCake = (int)reader[2];
                    string[] upgrades = reader[3].ToString().Trim().Split(' ');
                    for (int i = 0; i < upgrades.Length; i++)
                    {
                        user.upgradeCount[i] = int.Parse(upgrades[i]);
                    }
                    users.Add(user);
                    Console.WriteLine("\nQuery Executed - Retrieved User" + _connectionInfo._database);

                    index++;
                }
            }
            _connection.Close();
            return users;
        }

        public void InsertIntoScoreboard(int id, GameData userInfo)
        {
            try
            {
                _connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message + "\n");
                DisplayError("Couldn't Load Database.\n" +
                                "Check Log for more info");
                return;
            }

            if (userInfo.Id == -1)
            {
                StringBuilder strBuilder = new StringBuilder();
                strBuilder.Append("INSERT INTO ScoreBoard (ID, CakeScore)\n");
                strBuilder.Append("VALUES (N'" + id + "', N'" + userInfo.amountOfCake + "') ");

                string sqlQuery = strBuilder.ToString();
                using (SqlCommand command = new SqlCommand(sqlQuery, _connection))
                {

                    command.ExecuteNonQuery();
                    Console.WriteLine("\nQuery Executed - Saved score to " + _connectionInfo._database);
                }
            }
            else
            {

            }


            _connection.Close(); ;
        }

        
    }

    public struct ConnectionInfo
    {
        public string _dataSource;
        public string _database;
        public string _userId;
        public string _password;

        public ConnectionInfo(string dataSource, string database, string userId, string password)
        {
            _dataSource = dataSource;
            _database = database;
            _userId = userId;
            _password = password;
        }
    }
}

