using System.Security.Cryptography;
namespace AspLearnProject.Models
{
    public class User
    {
        private string _name;
        private string _surname;
        private string _username;
        private string _email;
        private string _password;
        public string Name
        {
            get => char.ToUpper(_name[0]) + _name.Substring(1).ToLower();
            set => _name = value;
        }
        public string Surname
        {
            get => _surname;
            set => _surname = value.ToUpper();
        }
        public string Username
        {
            get => _username;
            set => _username = value;
        }
        public string Email
        {
            get => _email;
            set => _email = value;
        }
        public string Password
        {
            get => _password;
            set
            {
                if (value.Length < 8 ||
                    !value.Any(char.IsUpper) ||
                    !value.Any(char.IsLower) ||
                    (!value.Any(char.IsSymbol) && !value.Any(char.IsPunctuation)))
                {
                    throw new Exception("Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one symbol.");
                }
                _password = value;
            }
        }
    }
}
