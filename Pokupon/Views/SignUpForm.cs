using Pokupon.DataAccess;
using Pokupon.Helpers;
using Pokupon.Models;

namespace Pokupon.Views;
public partial class SignUpForm : Form
{
	private readonly IDbService _dbService = new DbService();

	private readonly StringValidator _stringValidator = new();
	
	public SignUpForm()
	{
		InitializeComponent();
	}

	private void loginButton_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void signUpButton_Click(object sender, EventArgs e)
	{
		if(!_stringValidator.Validate(loginTextBox.Text, 3, 20).IsValid || 
		   !_stringValidator.Validate(passwordTextBox.Text, 3, 20).IsValid || 
		   !_stringValidator.Validate(repeatPasswordTextBox.Text, 3, 20).IsValid || 
		   !_stringValidator.Validate(emailTextBox.Text, 3, 20).IsValid)
			return;
		if (passwordTextBox.Text != repeatPasswordTextBox.Text)
			return;

		var user = new User(loginTextBox.Text, emailTextBox.Text, passwordTextBox.Text);
		_dbService.InsertUser(user);
		_dbService.SaveChanges();

		Close();
	}
}
