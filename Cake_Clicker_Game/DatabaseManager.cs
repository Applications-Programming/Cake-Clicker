using System;
using System.Data.SqlClient;


public class DatabaseManager
{

    SqlConnection _connection;

    /// <summary>
    /// Creates a DatabaseManager with a connection to the database provided
    /// </summary>
    /// <param name="dataSource">the database source (server/local)</param>
    /// <param name="database">the name of the database</param>
    /// <param name="UserId">SQL login ID</param>
    /// <param name="password">SQL login password</param>
    /// <returns>The created Database or null if connection failed</returns>
    public static DatabaseManager CreateDatabaseManager(string dataSource, string database, string UserId, string password)
    {

        Console.WriteLine("Getting Connection...");

        //your connection string 
        string connString = @"Data Source=" + dataSource + ";Initial Catalog="
                    + database + ";Persist Security Info=True;User ID=" + UserId + ";Password=" + password;

        //create instanace of database connection
        SqlConnection connection = new SqlConnection(connString);


        try
        {
            Console.WriteLine("Openning Connection ...");

            //open connection
            connection.Open();
            Console.WriteLine("Connection successful!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
            return null;
        }

        return new DatabaseManager(connection);
    }

    /// <summary>
    /// Constructor that takes in an existing connection
    /// </summary>
    DatabaseManager(SqlConnection connection)
    {
        _connection = connection;
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

    public Game.GameData GetAccountInfo(string uuid)
    {
        return new Game.GameData();
    }

    public Game.GameData GetAccountInfo(int id)
    {
        return new Game.GameData();
    }






}