namespace Pokupon.Views;

partial class SignUpForm
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
		signUpButton = new Button();
		passwordLabel = new Label();
		loginLabel = new Label();
		loginTextBox = new TextBox();
		passwordTextBox = new TextBox();
		repeatPasswordLabel = new Label();
		repeatPasswordTextBox = new TextBox();
		emailLabel = new Label();
		emailTextBox = new TextBox();
		SuspendLayout();
		// 
		// signUpButton
		// 
		signUpButton.FlatStyle = FlatStyle.Flat;
		signUpButton.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		signUpButton.ForeColor = Color.FromArgb(232, 171, 68);
		signUpButton.Location = new Point(267, 302);
		signUpButton.Name = "signUpButton";
		signUpButton.Size = new Size(232, 41);
		signUpButton.TabIndex = 5;
		signUpButton.Text = "Зареєструватись";
		signUpButton.UseVisualStyleBackColor = true;
		signUpButton.Click += signUpButton_Click;
		// 
		// passwordLabel
		// 
		passwordLabel.AutoSize = true;
		passwordLabel.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		passwordLabel.ForeColor = Color.FromArgb(232, 171, 68);
		passwordLabel.Location = new Point(74, 124);
		passwordLabel.Name = "passwordLabel";
		passwordLabel.Size = new Size(90, 27);
		passwordLabel.TabIndex = 10;
		passwordLabel.Text = "Пароль";
		// 
		// loginLabel
		// 
		loginLabel.AutoSize = true;
		loginLabel.FlatStyle = FlatStyle.System;
		loginLabel.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		loginLabel.ForeColor = Color.FromArgb(232, 171, 68);
		loginLabel.Location = new Point(74, 58);
		loginLabel.Name = "loginLabel";
		loginLabel.Size = new Size(77, 27);
		loginLabel.TabIndex = 9;
		loginLabel.Text = "Логін";
		// 
		// loginTextBox
		// 
		loginTextBox.BackColor = Color.FromArgb(33, 33, 33);
		loginTextBox.BorderStyle = BorderStyle.FixedSingle;
		loginTextBox.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		loginTextBox.ForeColor = Color.FromArgb(232, 171, 68);
		loginTextBox.Location = new Point(370, 56);
		loginTextBox.Name = "loginTextBox";
		loginTextBox.Size = new Size(327, 34);
		loginTextBox.TabIndex = 7;
		// 
		// passwordTextBox
		// 
		passwordTextBox.BackColor = Color.FromArgb(33, 33, 33);
		passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
		passwordTextBox.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		passwordTextBox.ForeColor = Color.FromArgb(232, 171, 68);
		passwordTextBox.Location = new Point(370, 122);
		passwordTextBox.Name = "passwordTextBox";
		passwordTextBox.Size = new Size(327, 34);
		passwordTextBox.TabIndex = 8;
		// 
		// repeatPasswordLabel
		// 
		repeatPasswordLabel.AutoSize = true;
		repeatPasswordLabel.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		repeatPasswordLabel.ForeColor = Color.FromArgb(232, 171, 68);
		repeatPasswordLabel.Location = new Point(74, 180);
		repeatPasswordLabel.Name = "repeatPasswordLabel";
		repeatPasswordLabel.Size = new Size(220, 27);
		repeatPasswordLabel.TabIndex = 14;
		repeatPasswordLabel.Text = "Повторіть пароль";
		// 
		// repeatPasswordTextBox
		// 
		repeatPasswordTextBox.BackColor = Color.FromArgb(33, 33, 33);
		repeatPasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
		repeatPasswordTextBox.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		repeatPasswordTextBox.ForeColor = Color.FromArgb(232, 171, 68);
		repeatPasswordTextBox.Location = new Point(370, 178);
		repeatPasswordTextBox.Name = "repeatPasswordTextBox";
		repeatPasswordTextBox.Size = new Size(327, 34);
		repeatPasswordTextBox.TabIndex = 3;
		// 
		// emailLabel
		// 
		emailLabel.AutoSize = true;
		emailLabel.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		emailLabel.ForeColor = Color.FromArgb(232, 171, 68);
		emailLabel.Location = new Point(74, 239);
		emailLabel.Name = "emailLabel";
		emailLabel.Size = new Size(77, 27);
		emailLabel.TabIndex = 16;
		emailLabel.Text = "Email";
		// 
		// emailTextBox
		// 
		emailTextBox.BackColor = Color.FromArgb(33, 33, 33);
		emailTextBox.BorderStyle = BorderStyle.FixedSingle;
		emailTextBox.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		emailTextBox.ForeColor = Color.FromArgb(232, 171, 68);
		emailTextBox.Location = new Point(370, 237);
		emailTextBox.Name = "emailTextBox";
		emailTextBox.Size = new Size(327, 34);
		emailTextBox.TabIndex = 4;
		// 
		// SignUpForm
		// 
		AutoScaleDimensions = new SizeF(8F, 20F);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(33, 33, 33);
		ClientSize = new Size(772, 405);
		Controls.Add(emailLabel);
		Controls.Add(emailTextBox);
		Controls.Add(repeatPasswordLabel);
		Controls.Add(repeatPasswordTextBox);
		Controls.Add(signUpButton);
		Controls.Add(passwordLabel);
		Controls.Add(loginLabel);
		Controls.Add(loginTextBox);
		Controls.Add(passwordTextBox);
		ForeColor = Color.FromArgb(33, 33, 33);
		FormBorderStyle = FormBorderStyle.Fixed3D;
		MaximizeBox = false;
		Name = "SignUpForm";
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion
	private Button signUpButton;
	private Label passwordLabel;
	private Label loginLabel;
	private TextBox loginTextBox;
	private TextBox passwordTextBox;
	private Label repeatPasswordLabel;
	private TextBox repeatPasswordTextBox;
	private Label emailLabel;
	private TextBox emailTextBox;
}