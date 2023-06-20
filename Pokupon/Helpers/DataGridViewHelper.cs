using System.Net;
using System.Net.Mail;
using Pokupon.DataAccess;
using Pokupon.Views;

namespace Pokupon.Helpers;

public class DataGridViewHelper
{
	private readonly IDbService _dbService;
	private readonly DataGridView _dealsDataGridView;

	public DataGridViewHelper(DataGridView dealsDataGridView, IDbService dbService)
	{
		_dealsDataGridView = dealsDataGridView;
		_dbService = dbService;
	}

	private DataGridViewHelper ClearColumns()
	{
		_dealsDataGridView.DataSource = null;
		_dealsDataGridView.Columns.Clear();
		return this;
	}

	private void SendEmail(string recipientEmail, string subject, string body)
	{
		var senderEmail = "bohdanefremenko@gmail.com";
		var senderPassword = "testtesttesttest";

		var mail = new MailMessage();
		mail.From = new MailAddress(senderEmail);
		mail.To.Add(recipientEmail);
		mail.Subject = subject;
		mail.Body = body;

		var smtpClient = new SmtpClient("smtp.gmail.com", 465);
		smtpClient.UseDefaultCredentials = false;
		smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
		smtpClient.EnableSsl = true;

		smtpClient.Send(mail);
	}

	public DataGridViewHelper UpdateData()
	{
		return ClearColumns().FillData();
	}

	public DataGridViewHelper FillData()
	{
		var bindingSource = new BindingSource();
		bindingSource.DataSource = _dbService.GetDeals().Select(deal => new
		{
			deal.Title,
			deal.Description,
			deal.Discount
		}).ToList();

		_dealsDataGridView.AutoGenerateColumns = false;
		_dealsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

		var titleColumn = new DataGridViewTextBoxColumn();
		titleColumn.HeaderText = @"Назва";
		titleColumn.DataPropertyName = "Title";
		titleColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
		titleColumn.Width = 320;
		//titleColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		_dealsDataGridView.Columns.Add(titleColumn);

		var descriptionColumn = new DataGridViewTextBoxColumn();
		descriptionColumn.HeaderText = @"Опис";
		descriptionColumn.DataPropertyName = "Description";
		descriptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		descriptionColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
		//descriptionColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		_dealsDataGridView.Columns.Add(descriptionColumn);

		var discountColumn = new DataGridViewTextBoxColumn();
		discountColumn.HeaderText = @"Знижка";
		discountColumn.DataPropertyName = "Discount";
		discountColumn.Width = 150;
		discountColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		_dealsDataGridView.Columns.Add(discountColumn);

		_dealsDataGridView.DataSource = bindingSource;
		return this;
	}

	public void UpdateSearchedData(string searchTerm, string searchBy)
	{
		var bindingSource = new BindingSource();
		bindingSource.DataSource = _dbService.SearchDeals(searchTerm, searchBy);

		_dealsDataGridView.AutoGenerateColumns = false;
		_dealsDataGridView.DataSource = bindingSource;
	}
}