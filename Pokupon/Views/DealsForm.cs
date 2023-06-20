using Newtonsoft.Json;
using Pokupon.DataAccess;
using Pokupon.Helpers;

namespace Pokupon.Views;

public partial class DealsForm : Form
{
	private readonly IDbService _dbService = new DbService();
	private readonly DataGridViewHelper _dataGridViewHelper;

	public DealsForm()
	{
		InitializeComponent();

		_dataGridViewHelper = new DataGridViewHelper(DealsDataGridView, _dbService);
		_dataGridViewHelper.FillData();
	}

	private void NewRecordButton_Click(object sender, EventArgs e)
	{
		var newRecordForm = new NewRecordForm();
		newRecordForm.Show();
		newRecordForm.FormClosed += (_, _) => _dataGridViewHelper.UpdateData();
	}

	private void ExportButton_Click(object sender, EventArgs e)
	{
		var json = JsonConvert.SerializeObject(_dbService.GetDeals());
		saveAsJsonDialog.Filter = @"(*.json)|*.json";
		saveAsJsonDialog.FileName = "Deals" + ".json";
		var result = saveAsJsonDialog.ShowDialog();

		if (result == DialogResult.OK)
		{
			var filePath = saveAsJsonDialog.FileName;

			File.WriteAllText(filePath, json);
		}
	}

	private void SearchByTitleTextBoxTextChanged(object sender, EventArgs e)
	{
		_dataGridViewHelper.UpdateSearchedData(SearchByTitleTextBox.Text, nameof(SearchByTitleTextBox));
	}

	private void SearchByDescriptionTextBox_TextChanged(object sender, EventArgs e)
	{
		_dataGridViewHelper.UpdateSearchedData(SearchByDescriptionTextBox.Text, nameof(SearchByDescriptionTextBox));
	}

	private void SearchByDiscountTextBox_TextChanged(object sender, EventArgs e)
	{
		_dataGridViewHelper.UpdateSearchedData(SearchByDiscountTextBox.Text, nameof(SearchByDiscountTextBox));
	}

	private void DealsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		var emailForm = new EmailForm();
		emailForm.Show();
	}
}