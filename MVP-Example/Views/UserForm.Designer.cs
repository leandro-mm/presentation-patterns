namespace MVP_Example;

partial class UserForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        txtUserId = new TextBox();
        txtFirstName = new TextBox();
        label1 = new Label();
        label2 = new Label();
        btnSave = new Button();
        btnLoad = new Button();
        btnClear = new Button();
        errorProvider1 = new ErrorProvider(components);
        bindingSource1 = new BindingSource(components);
        ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
        SuspendLayout();
        // 
        // txtUserId
        // 
        txtUserId.Location = new Point(183, 45);
        txtUserId.Name = "txtUserId";
        txtUserId.Size = new Size(237, 23);
        txtUserId.TabIndex = 0;
        // 
        // txtFirstName
        // 
        txtFirstName.Location = new Point(183, 76);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new Size(237, 23);
        txtFirstName.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(114, 45);
        label1.Name = "label1";
        label1.Size = new Size(18, 15);
        label1.TabIndex = 2;
        label1.Text = "ID";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(113, 79);
        label2.Name = "label2";
        label2.Size = new Size(64, 15);
        label2.TabIndex = 2;
        label2.Text = "First Name";
        // 
        // btnSave
        // 
        btnSave.Location = new Point(183, 116);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(75, 23);
        btnSave.TabIndex = 3;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = true;
        // 
        // btnLoad
        // 
        btnLoad.Location = new Point(264, 116);
        btnLoad.Name = "btnLoad";
        btnLoad.Size = new Size(75, 23);
        btnLoad.TabIndex = 3;
        btnLoad.Text = "Load";
        btnLoad.UseVisualStyleBackColor = true;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(345, 116);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(75, 23);
        btnClear.TabIndex = 3;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        // 
        // errorProvider1
        // 
        errorProvider1.ContainerControl = this;
        // 
        // UserForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnClear);
        Controls.Add(btnLoad);
        Controls.Add(btnSave);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(txtFirstName);
        Controls.Add(txtUserId);
        Name = "UserForm";
        Text = "User Form";
        ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
        ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtUserId;
    private TextBox txtFirstName;
    private Label label1;
    private Label label2;
    private Button btnSave;
    private Button btnLoad;
    private Button btnClear;
    private ErrorProvider errorProvider1;
    private BindingSource bindingSource1;
}
