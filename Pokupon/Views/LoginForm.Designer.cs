namespace Pokupon.Views;

partial class LoginForm
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
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
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		PasswordTextBox = new TextBox();
		LoginTextBox = new TextBox();
		loginLabel = new Label();
		passwordLabel = new Label();
		loginButton = new Button();
		signInLable = new Label();
		signUpButton = new Button();
		withoutAccountButton = new Button();
		SuspendLayout();
		// 
		// PasswordTextBox
		// 
		PasswordTextBox.BackColor = Color.FromArgb(33, 33, 33);
		PasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
		PasswordTextBox.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		PasswordTextBox.ForeColor = Color.FromArgb(232, 171, 68);
		PasswordTextBox.Location = new Point(914, 316);
		PasswordTextBox.Name = "PasswordTextBox";
		PasswordTextBox.Size = new Size(236, 34);
		PasswordTextBox.TabIndex = 2;
		// 
		// LoginTextBox
		// 
		LoginTextBox.BackColor = Color.FromArgb(33, 33, 33);
		LoginTextBox.BorderStyle = BorderStyle.FixedSingle;
		LoginTextBox.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		LoginTextBox.ForeColor = Color.FromArgb(232, 171, 68);
		LoginTextBox.Location = new Point(914, 205);
		LoginTextBox.Name = "LoginTextBox";
		LoginTextBox.Size = new Size(236, 34);
		LoginTextBox.TabIndex = 1;
		// 
		// loginLabel
		// 
		loginLabel.AutoSize = true;
		loginLabel.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		loginLabel.ForeColor = Color.FromArgb(232, 171, 68);
		loginLabel.Location = new Point(792, 207);
		loginLabel.Name = "loginLabel";
		loginLabel.Size = new Size(77, 27);
		loginLabel.TabIndex = 3;
		loginLabel.Text = "Логін";
		// 
		// passwordLabel
		// 
		passwordLabel.AutoSize = true;
		passwordLabel.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		passwordLabel.ForeColor = Color.FromArgb(232, 171, 68);
		passwordLabel.Location = new Point(792, 316);
		passwordLabel.Name = "passwordLabel";
		passwordLabel.Size = new Size(90, 27);
		passwordLabel.TabIndex = 4;
		passwordLabel.Text = "Пароль";
		// 
		// loginButton
		// 
		loginButton.FlatStyle = FlatStyle.Flat;
		loginButton.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		loginButton.ForeColor = Color.FromArgb(232, 171, 68);
		loginButton.Location = new Point(792, 428);
		loginButton.Name = "loginButton";
		loginButton.Size = new Size(358, 41);
		loginButton.TabIndex = 5;
		loginButton.Text = "Увійти";
		loginButton.UseVisualStyleBackColor = true;
		loginButton.Click += loginButton_Click;
		// 
		// signInLable
		// 
		signInLable.AutoSize = true;
		signInLable.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		signInLable.ForeColor = Color.FromArgb(232, 171, 68);
		signInLable.Location = new Point(833, 534);
		signInLable.Name = "signInLable";
		signInLable.Size = new Size(246, 27);
		signInLable.TabIndex = 14;
		signInLable.Text = "Не маєте аккаунту?";
		signInLable.TextAlign = ContentAlignment.MiddleCenter;
		// 
		// signUpButton
		// 
		signUpButton.FlatStyle = FlatStyle.Flat;
		signUpButton.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		signUpButton.ForeColor = Color.FromArgb(232, 171, 68);
		signUpButton.Location = new Point(792, 589);
		signUpButton.Name = "signUpButton";
		signUpButton.Size = new Size(358, 41);
		signUpButton.TabIndex = 13;
		signUpButton.Text = "Реєстрація";
		signUpButton.UseVisualStyleBackColor = true;
		signUpButton.Click += signUpButton_Click;
		// 
		// withoutAccountButton
		// 
		withoutAccountButton.FlatStyle = FlatStyle.Flat;
		withoutAccountButton.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		withoutAccountButton.ForeColor = Color.FromArgb(232, 171, 68);
		withoutAccountButton.Location = new Point(792, 682);
		withoutAccountButton.Name = "withoutAccountButton";
		withoutAccountButton.Size = new Size(358, 46);
		withoutAccountButton.TabIndex = 15;
		withoutAccountButton.Text = "Продовжити без аккаунту";
		withoutAccountButton.UseVisualStyleBackColor = true;
		withoutAccountButton.Click += withoutAccountButton_Click;
		// 
		// LoginForm
		// 
		AutoScaleDimensions = new SizeF(8F, 20F);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(33, 33, 33);
		ClientSize = new Size(1842, 817);
		Controls.Add(loginLabel);
		Controls.Add(withoutAccountButton);
		Controls.Add(signInLable);
		Controls.Add(signUpButton);
		Controls.Add(loginButton);
		Controls.Add(passwordLabel);
		Controls.Add(LoginTextBox);
		Controls.Add(PasswordTextBox);
		ForeColor = Color.FromArgb(33, 33, 33);
		FormBorderStyle = FormBorderStyle.Fixed3D;
		Name = "LoginForm";
		SizeGripStyle = SizeGripStyle.Hide;
		WindowState = FormWindowState.Maximized;
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Label loginLabel;
	private Label passwordLabel;
	private Label signInLable;
	private TextBox LoginTextBox;
	private TextBox PasswordTextBox;
	private Button loginButton;
	private Button signUpButton;
	private Button withoutAccountButton;
}