using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
public class Task2
{
    public void Launch()
    {
        var UserList = new UserManager();
        var user = new User("Jan", "www@e.mail", "Admin");

        UserList.AddUser(user);
        Console.WriteLine("User added");
        UserList.ShowAllUsers();

        UserList.UpdateUser("Naj", "www@e.mail", "Moderator");
        Console.WriteLine("Name and role changed");
        UserList.ShowAllUsers();

        UserList.RemoveUser(user);
        Console.WriteLine("Removed");
        UserList.ShowAllUsers();
    }
}