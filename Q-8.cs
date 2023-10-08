using System;

public enum UserRoles
{
    Administrator,
    Moderator,
    User
}

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public UserRoles Role { get; set; }
}

public class UserRegistration
{
    public User RegisterUser(string username, string password, UserRoles role)
    {
       
        if (IsValidUserRole(role))
        {
            User newUser = new User
            {
                Username = username,
                Password = password,
                Role = role
            };
            Console.WriteLine($"User {newUser.Username} registered with role: {newUser.Role}");
            return newUser;
        }
        else
        {
            throw new ArgumentException("Invalid user role.");
        }
    }
    private bool IsValidUserRole(UserRoles role)
    {
       
        return Enum.IsDefined(typeof(UserRoles), role);
    }
}
class Program
{
    static void Main()
    {
        UserRegistration registrationSystem = new UserRegistration();
        try
        {
            User user1 = registrationSystem.RegisterUser("admin", "adminpass", UserRoles.Administrator);
            User user2 = registrationSystem.RegisterUser("moderator", "modpass", UserRoles.Moderator);
            User user3 = registrationSystem.RegisterUser("user", "userpass", UserRoles.User);
           
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }