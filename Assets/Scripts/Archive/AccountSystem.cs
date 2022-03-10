using System.Collections;

namespace Archive
{
    public class AccountSystem
    {
        private ArrayList _users;

        private string _dataPath;

        public ArrayList Users
        {
            get => _users;
            set => _users = value;
        }

        public string DataPath
        {
            get => _dataPath;
            set => _dataPath = value;
        }

        public void AddUser(string userName,string userPassword)
        {
            User user = new User(userName,userPassword);
        }
    }
}