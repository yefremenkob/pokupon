using System.ComponentModel;

namespace Pokupon.Views;

partial class EmailForm
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private IContainer components = null;

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
		SearchLabel = new Label();
		newRecordButton = new Button();
		SuspendLayout();
		// 
		// SearchLabel
		// 
		SearchLabel.AutoEllipsis = true;
		SearchLabel.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		SearchLabel.ForeColor = Color.FromArgb(232, 171, 68);
		SearchLabel.Location = new Point(52, 42);
		SearchLabel.Name = "SearchLabel";
		SearchLabel.RightToLeft = RightToLeft.No;
		SearchLabel.Size = new Size(361, 60);
		SearchLabel.TabIndex = 21;
		SearchLabel.Text = "Купон був успішно відправлений вам на пошту";
		SearchLabel.TextAlign = ContentAlignment.MiddleCenter;
		// 
		// newRecordButton
		// 
		newRecordButton.FlatStyle = FlatStyle.Flat;
		newRecordButton.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		newRecordButton.ForeColor = Color.FromArgb(232, 171, 68);
		newRecordButton.Location = new Point(115, 136);
		newRecordButton.Name = "newRecordButton";
		newRecordButton.Size = new Size(215, 67);
		newRecordButton.TabIndex = 22;
		newRecordButton.Text = "Закрити";
		newRecordButton.UseVisualStyleBackColor = true;
		newRecordButton.Click += newRecordButton_Click;
		// 
		// EmailForm
		// 
		AutoScaleDimensions = new SizeF(8F, 20F);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(33, 33, 33);
		ClientSize = new Size(458, 255);
		Controls.Add(newRecordButton);
		Controls.Add(SearchLabel);
		Name = "EmailForm";
		Text = "EmailForm";
		ResumeLayout(false);
	}

	#endregion

	private Label SearchLabel;
	public Button newRecordButton;
}