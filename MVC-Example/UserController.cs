namespace MVC_Example;

public class UserController
{
    private readonly User _model;
    private readonly UserView _view;

    public UserController(User model, UserView view)
    {
        _model = model;
        _view = view;
    }

    public void UpdateUserName()
    {
        string? newName = _view.GetUserInput();
        if (!string.IsNullOrEmpty(newName))
        {
            _model.Name = newName;
            DisplayUser();
        }
        else
        {
            Console.WriteLine("Invalid input. User name cannot be empty.");
        }
    }

    public void DisplayUser()
    {
        _view.ShowUser(_model);
    }
}