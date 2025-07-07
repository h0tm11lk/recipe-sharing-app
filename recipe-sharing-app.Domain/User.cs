public class User
{
    public UserId UserId { get; set; }
    public string UserName { get; set; }
    public EmailAddress Email { get; set; }
    public int PasswordHash { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public void ChangeUserName()
    {

    }

    public void ChangePasword()
    {

    }

    public void UpdateProfile()
    {

    }

    public void UpdateLastLoginTime()
    {
        
    }
}