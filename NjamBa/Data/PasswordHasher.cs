using BCrypt.Net;
namespace NjamBa.Data
{
    public class PasswordHasher
    {
        public string HashPassword(string plainTextPassword)
        {
            // Generate a new salt for this password
            string salt = BCrypt.Net.BCrypt.GenerateSalt();

            // Hash the password with the generated salt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(plainTextPassword, salt);

            return hashedPassword;
        }

        public bool VerifyPassword(string plainTextPassword, string hashedPassword)
        {
            // Verify the hashed password against the plain text password
            return BCrypt.Net.BCrypt.Verify(plainTextPassword, hashedPassword);
        }
    }
}
