using MVP_Example.Models;
using MVP_Example.Views;
using System.Windows.Forms;

namespace MVP_Example.Presenters;

public class UserPresenter
{
    private readonly IUserView _view;
    private readonly IUserRepository _repository;
    private readonly BindingSource _bindingSource;


    public UserPresenter(IUserView view, IUserRepository repository)
    {
        _view = view;
        _repository = repository;       

        // Set up data binding
        _bindingSource = new BindingSource();
        _bindingSource.DataSource = GetUserDataSource();
        _view.SetUserBindingSource(_bindingSource);

        // Subscribe to view events
        _view.LoadUser += OnLoadUser;
        _view.SaveUser += OnSaveUser;
        _view.ClearForm += OnClearForm;
    }

    private void OnLoadUser(object sender, EventArgs e)
    {
        try
        {
            var user = _repository.GetUser(_view.UserId);
            if (user != null && user.Id != 0)
            {
                _bindingSource.DataSource = user;
                _view.IsEditMode = true;
                
                _view.ShowMessage("User loaded successfully!", "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                _view.ShowMessage($"User {_view.UserId} not found", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error loading user: {ex.Message}", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void OnSaveUser(object sender, EventArgs e)
    {
        try
        {
            UserModel user = GetUserDataSource();

            // Update model with view data
            user.FirstName = _view.FirstName;

            // Validate
            if (!_repository.ValidateUser(user))
            {
                _view.ShowMessage("Please check all fields",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Save            
            _repository.SaveUser(user);

            _view.ShowMessage("User saved successfully!", "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            _view.IsEditMode = false;
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error saving user: {ex.Message}", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private UserModel GetUserDataSource()
    {
        return (UserModel?)_bindingSource.DataSource ?? new UserModel();
    }

    private void OnClearForm(object sender, EventArgs e)
    {
        _bindingSource.DataSource = new UserModel();
        _view.FirstName = string.Empty;          
        _view.UserId = 0;
        _view.IsEditMode = false;
    }
}