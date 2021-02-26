using Cake_Clicker_Game;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;



public class DatabaseManager
{

    SqlConnection _connection;
    ConnectionInfo _connectionInfo;


    /// <summary>
    /// Creates a DatabaseManager with a connection to the database provided
    /// </summary>
    /// <param name="dataSource">the database source (server/local)</param>
    /// <param name="database">the name of the database</param>
    /// <param name="UserId">SQL login ID</param>
    /// <param name="password">SQL login password</param>
    /// <returns>The created Database or null if connection failed</returns>
    public static DatabaseManager CreateDatabaseManager(ConnectionInfo connectionInfo)
    {
        Console.WriteLine("Getting Database Connection:");

        //your connection string 
        string connString = @"Data Source=" + connectionInfo._dataSource + ";Initial Catalog="
                    + connectionInfo._database + ";Persist Security Info=True;User ID=" + connectionInfo._userId + ";Password=" + connectionInfo._password;

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
            MessageBox.Show("Couldn't Load Database.\n" +
                            "Check Log for more info");
            return null;
        }
        Console.Out.Flush();
        return new DatabaseManager(connection, connectionInfo);
    }

    /// <summary>
    /// Constructor that takes in an existing connection
    /// </summary>
    DatabaseManager(SqlConnection connection, ConnectionInfo connectionInfo)
    {
        _connection = connection;
        _connectionInfo = connectionInfo;
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
    private void SetConnection(SqlConnection connection)
    {
        _connection = connection;
    }

    /// <summary>
    /// Saves GameData to the database
    /// </summary>
    /// <param name="uuid">the user id (username-Id)</param>
    /// <param name="ammountOfCake">The amount of cake the user has</param>
    /// <param name="upgrades">the users current upgrades</param>
    public void SaveToDatabase(string uuid, int ammountOfCake, int[] upgrades)
    {
        /** Working Insert Setup **/
        /*
        Console.WriteLine("\n");

        string[] id = uuid.Split('-');

        StringBuilder strBuilder = new StringBuilder();
        strBuilder.Append("INSERT INTO UserScores (Id, Name, Cake, Cake_Upgrades) VALUES ");
        strBuilder.Append("(N'" + id[0] + "', N'" + id[1] + "', N'" + ammountOfCake + "', N'" + "10" + "') ");

        string sqlQuery = strBuilder.ToString();
        using (SqlCommand command = new SqlCommand(sqlQuery, _connection))
        {
            command.ExecuteNonQuery();
            Console.WriteLine("Query Executed");
        }
        */



    }

    /// <summary>
    /// Saves GameData to the database
    /// </summary>
    /// <param name="game">the game to be saved</param>
    public void SaveToDatabase(Game.GameData gameData)
    {

    }

    /// <summary>
    /// Updates the given users GameData
    /// </summary>
    /// <returns>false if account doesn't exist</returns>
    public bool UpdateAccountGameData(Game.GameData gameData)
    {
        return false;
    }

    /// <summary>
    /// Gets the GameData of the given user
    /// </summary>
    /// <param name="uuid">The Users uuid</param>
    /// <returns></returns>
    public Game.GameData GetAccountInfo(string uuid)
    {
        return new Game.GameData();
    }

    /// <summary>
    /// Gets the GameData of the specified Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Game.GameData GetAccountInfo(int id)
    {
        return new Game.GameData();
    }

    public ConnectionInfo GetConnectionInfo() { return _connectionInfo; }

    //Database Clear should be done manually

    public struct ConnectionInfo{
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