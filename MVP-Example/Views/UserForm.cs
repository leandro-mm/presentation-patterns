using MVP_Example.Models;
using MVP_Example.Presenters;
using MVP_Example.Views;
using System.ComponentModel;

namespace MVP_Example;

public partial class UserForm : Form, IUserView
{
    private UserPresenter _presenter;  

    public UserForm()
    {
        InitializeComponent();
        InitializePresenter();
        WireUpEvents();
    }

 
    private void InitializePresenter()
    {
        var repository = new UserRepository();
        _presenter = new UserPresenter(this, repository);
    }
   

    private void WireUpEvents()
    {
        // Wire up button click events to the form's event handlers
        btnLoad.Click += BtnLoad_Click;
        btnSave.Click += BtnSave_Click;
        btnClear.Click += BtnClear_Click;
    }

    private void BtnLoad_Click(object sender, EventArgs e)
    {
        // Raise the LoadUser event which the presenter is
        // subscribed to
        LoadUser?.Invoke(this, EventArgs.Empty);
    }
    private void BtnSave_Click(object sender, EventArgs e)
    {
        // Raise the SaveUser event which the presenter is
        // subscribed to
        SaveUser?.Invoke(this, EventArgs.Empty);
    }

    private void BtnClear_Click(object sender, EventArgs e)
    {
        // Raise the ClearForm event which the presenter is
        // subscribed to
        ClearForm?.Invoke(this, EventArgs.Empty);
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int UserId
    {
        get => int.TryParse(txtUserId.Text, out int id) ? id : 0;
        set => txtUserId.Text = value.ToString();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string FirstName
    {
        get => txtFirstName.Text;
        set =>  txtFirstName.Text = value;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsEditMode
    {
        get => txtUserId.Enabled;
        set
        {
            txtUserId.Enabled = value;
            btnLoad.Enabled = !value;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string Message
    {
        get => string.Empty;
        set => ShowMessage(value, "User Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // Events that the presenter will subscribe to
    public event EventHandler LoadUser;
    public event EventHandler SaveUser;
    public event EventHandler ClearForm;

    public void SetUserBindingSource(BindingSource userBindingSource)
    {
        bindingSource1 = userBindingSource;        

        if (bindingSource1.DataSource != null)
        {
            txtFirstName.DataBindings.Clear();

            txtFirstName.DataBindings.Add(
               "Text",
               bindingSource1,
               "FirstName",
               true,
               DataSourceUpdateMode.OnPropertyChanged
           );
        }
        else
        {
            ShowMessage("DataSource is not ready", 
                "Error", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Warning);
        }
           
    }

    public void ShowMessage(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
    {
        switch (icon)
        {
            case MessageBoxIcon.None:
                MessageBox.Show(message, title, buttons, icon);
                break; ;            
            case MessageBoxIcon.Question:
                MessageBox.Show(message, title, buttons, icon);
                break; ;
            case MessageBoxIcon.Error:
                errorProvider1.SetError(txtFirstName, message);
                break;
            case MessageBoxIcon.Warning:
                MessageBox.Show(message, title, buttons, icon);
                break; ;
            case MessageBoxIcon.Information:
                MessageBox.Show(message, title, buttons, icon);
                break; ;
            default:
                MessageBox.Show(message, title, buttons, icon);
                break;
        }
        
    }
}
