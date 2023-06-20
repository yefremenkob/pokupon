using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Pokupon.Views;

public partial class EmailForm : Form
{
	public EmailForm()
	{
		InitializeComponent();
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

	private void newRecordButton_Click(object sender, EventArgs e)
	{
		Close();
	}
}