namespace MVC_Example;

public class UserView
{
    public void ShowUser(User user)
    {
        Console.WriteLine($"User ID: {user.Id}");
        Console.WriteLine($"User Name: {user.Name}");
    }

    public string? GetUserInput()
    {
        Console.WriteLine("Enter user name:");
        return Console.ReadLine();
    }
}