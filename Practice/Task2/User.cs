public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }

    public User(string name, string email, string role)
    {
        this.Name = name;
        this.Email = email;
        this.Role = role;
    }
}