using FluentValidation;
using Pokupon.DataAccess;
using Pokupon.Helpers;
using Pokupon.Models;

namespace Pokupon.Views;

public partial class NewRecordForm : Form
{
	private readonly IDbService _dbService = new DbService();

	private readonly StringValidator _stringValidator = new();
	
	public NewRecordForm()
	{
		InitializeComponent();
	}

	private void NewRecordButton_Click(object sender, EventArgs e)
	{
		if(!_stringValidator.Validate(TitleTextBox.Text, 3, 50).IsValid || !_stringValidator.Validate(DescriptionTextBox.Text, 3, 3000).IsValid)
			return;

		if (!int.TryParse(DiscountTextBox.Text, out var discount))
			return;
		if (discount is > 100 or < 0)
			return;

		var deal = new Deal(TitleTextBox.Text, DescriptionTextBox.Text, discount);

		_dbService.InsertDeal(deal);
		_dbService.SaveChanges();
		this.Close();
	}
}