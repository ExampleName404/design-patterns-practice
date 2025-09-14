
public class UserManager
{
    public List<User> UserList { get; } = new List<User>();

    // add
    public void AddUser(User userList) => UserList.Add(userList);
    // remove
    public void RemoveUser(User userList) => UserList.Remove(userList);
    // update ( наглядный пример, почитал если большое количество пользователей то словарь нужен или индексирование но это уже оптимизация а не решения задачи :) )
    public void UpdateUser(string name, string email, string role)
    {
        var user = UserList.FirstOrDefault(u => u.Email == email);
        if (user != null)
        {
            user.Name = name;
            user.Role = role;
            // Если появятся новые свойства
        }
    }
    // Display users
    public void ShowAllUsers()
    {
        foreach (var user in UserList)
        {
            Console.WriteLine($"Name {user.Name}, Email {user.Email}, Role {user.Role}");
        }
    }

}