using Pokupon.DataAccess;
using Pokupon.Helpers;

namespace Pokupon.Views;
public partial class LoginForm : Form
{
	private readonly IDbService _dbService = new DbService();

	private readonly StringValidator _stringValidator = new();

	public LoginForm()
	{
		InitializeComponent();
	}

	private void loginButton_Click(object sender, EventArgs e)
	{
		if (!_stringValidator.Validate(LoginTextBox.Text, 3, 20).IsValid || !_stringValidator.Validate(PasswordTextBox.Text, 3, 20).IsValid)
			return;

		var users = _dbService.GetUsers();

		var isUserFound = users.Any(user => LoginTextBox.Text == user.Name && PasswordTextBox.Text == user.Password);

		if (isUserFound)
		{
			var tableEditorForm = new DealsForm();
			Hide();
			tableEditorForm.Show();
			tableEditorForm.FormClosed += (_, _) => Show();
		}
		else
		{
			var errorForm = new ErrorForm();
			errorForm.Show();
			errorForm.FormClosed += (_, _) => Show();
		}

	}
	private void signUpButton_Click(object sender, EventArgs e)
	{
		var signUpForm = new SignUpForm();
		signUpForm.Show();
	}

	private void withoutAccountButton_Click(object sender, EventArgs e)
	{
		var tableEditorForm = new DealsForm();
		tableEditorForm.newRecordButton.Enabled = false;
		Hide();
		tableEditorForm.Show();
		tableEditorForm.FormClosed += (_, _) => Show();
	}
}