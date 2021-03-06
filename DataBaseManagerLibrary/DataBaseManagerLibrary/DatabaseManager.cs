using System;
using System.Data.SqlClient;
using System.Text;


namespace DataBaseManagerLibrary
{
    public class DatabaseManager
    {
        public DatabaseManager(ConnectionInfo connectionInfo, Action<string> sendUserMessage)
        {
        }

        public int SaveToDatabase(UserData gameInfo)
        {
            throw new NotImplementedException();
        }

        public UserData GetUserInfo(int id)
        {
            throw new NotImplementedException();
        }
    }
}

