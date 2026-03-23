namespace MVP_Example.Models;

public class UserRepository : IUserRepository
{    
    List<UserModel> _users = [];

    // Simulating database operations
    public UserModel GetUser(int id)
    {
        // In real app, this would query a database
        return _users.FirstOrDefault(u => u.Id == id) ?? new UserModel { Id=0, FirstName="user not found"};
    }

    public void SaveUser(UserModel user)
    {
        if (_users.Any())
        {
            user.Id = _users.Select(s => s.Id).Max() + 1;
        }
        else
        {
            user.Id = 1;
        }
        _users.Add(user);
    }

    public bool ValidateUser(UserModel user)
    {
        if (string.IsNullOrWhiteSpace(user.FirstName))
            return false;

        return true;
    }
}