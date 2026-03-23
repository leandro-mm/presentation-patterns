namespace MVP_Example.Views;

public interface IUserView
{
    int UserId { get; set; }
    string FirstName { get; set; }

    // UI State
    bool IsEditMode { get; set; }
    string Message { get; set; }

    // Events
    event EventHandler LoadUser;
    event EventHandler SaveUser;
    event EventHandler ClearForm;

    // Methods
    void ShowMessage(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon);
    void SetUserBindingSource(BindingSource userBindingSource);
}