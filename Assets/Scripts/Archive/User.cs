using System.Collections;

namespace Archive
{
    public class User
    {
        private string _account;

        private string _password;

        private Archive _archives ;
        
        public string Account
        {
            get => _account;
            set => _account = value;
        }

        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public Archive Archives
        {
            get => _archives;
            set => _archives = value;
        }

        public User(string userName,string userPassword)
        {
            this.Account = userName;
            this.Password = userPassword;
            Archive archive = new Archive(userName);
            this.Archives = archive;
        }
    }
}