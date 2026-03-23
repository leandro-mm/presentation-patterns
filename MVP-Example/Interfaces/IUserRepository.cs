using MVP_Example.Models;

namespace MVP_Example;

public interface IUserRepository
{
    UserModel GetUser(int id);
    void SaveUser(UserModel user);
    bool ValidateUser(UserModel user);
}