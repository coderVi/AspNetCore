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
                _password = HashPasswordWithGUID(value);
            }
        }

        private string HashPasswordWithGUID(string password)
        {
            // Şifre hashleme işlemi için method
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Combine password and GUID
                string combinedPassword = password + Guid.NewGuid().ToString();
                // Convert the combined password to a byte array
                byte[] bytes = sha256Hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(combinedPassword));
                // Convert byte array to a string
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }
    }
}
