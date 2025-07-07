public class User
{
    private UserId id;
    private string userName;
    private EmailAddress email;
    private int passwordHash;
    private DateTime createdAt;
    private DateTime updatedAt;

    public void ChangeUserName(string newUserName)
    {
        if (string.IsNullOrEmpty(newUserName))
        {
            throw new ArgumentException("User name cannot be null or empty.", nameof(newUserName));
        }

        if (newUserName.Length < 3 || newUserName.Length > 50)
        {
            throw new ArgumentException("User name must be between 1 and 50 characters long.", nameof(newUserName));
        }
        this.userName = newUserName;
    }

    public void ChangePassword(string oldPassword, string newPassword, PasswordHasher passwordHasher)
    {
        if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword))
        {
            throw new ArgumentException("Passwords cannot be null or empty.");
        }

        if (oldPassword == newPassword)
        {
            throw new ArgumentException("New password must be different from the old password.");
        }

        // Here you would typically hash the new password and store it
        this.passwordHash = newPassword.GetHashCode(); // Simplified for example purposes
    }

    public void UpdateProfile(UpdateUserDto dto)
    {
        this.createdAt = DateTime.Now;
    }

    public void UpdateLastLoginTime()
    {
        this.updatedAt = DateTime.Now;
    }
}