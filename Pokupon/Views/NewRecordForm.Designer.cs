using System.ComponentModel;

namespace Pokupon.Views;

partial class NewRecordForm
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
		DiscountLable = new Label();
		DiscountTextBox = new TextBox();
		DescriptionLable = new Label();
		DescriptionTextBox = new TextBox();
		TitleLabel = new Label();
		TitleTextBox = new TextBox();
		NewRecordButton = new Button();
		SuspendLayout();
		// 
		// DiscountLable
		// 
		DiscountLable.AutoSize = true;
		DiscountLable.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		DiscountLable.ForeColor = Color.FromArgb(232, 171, 68);
		DiscountLable.Location = new Point(75, 329);
		DiscountLable.Name = "DiscountLable";
		DiscountLable.Size = new Size(272, 27);
		DiscountLable.TabIndex = 22;
		DiscountLable.Text = "Знижка (у відсотках)";
		// 
		// DiscountTextBox
		// 
		DiscountTextBox.BackColor = Color.FromArgb(33, 33, 33);
		DiscountTextBox.BorderStyle = BorderStyle.FixedSingle;
		DiscountTextBox.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		DiscountTextBox.ForeColor = Color.FromArgb(232, 171, 68);
		DiscountTextBox.Location = new Point(75, 380);
		DiscountTextBox.Name = "DiscountTextBox";
		DiscountTextBox.Size = new Size(125, 34);
		DiscountTextBox.TabIndex = 21;
		// 
		// DescriptionLable
		// 
		DescriptionLable.AutoSize = true;
		DescriptionLable.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		DescriptionLable.ForeColor = Color.FromArgb(232, 171, 68);
		DescriptionLable.Location = new Point(75, 131);
		DescriptionLable.Name = "DescriptionLable";
		DescriptionLable.Size = new Size(168, 27);
		DescriptionLable.TabIndex = 20;
		DescriptionLable.Text = "Опис послуги";
		// 
		// DescriptionTextBox
		// 
		DescriptionTextBox.BackColor = Color.FromArgb(33, 33, 33);
		DescriptionTextBox.BorderStyle = BorderStyle.FixedSingle;
		DescriptionTextBox.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		DescriptionTextBox.ForeColor = Color.FromArgb(232, 171, 68);
		DescriptionTextBox.Location = new Point(75, 177);
		DescriptionTextBox.Multiline = true;
		DescriptionTextBox.Name = "DescriptionTextBox";
		DescriptionTextBox.Size = new Size(829, 137);
		DescriptionTextBox.TabIndex = 19;
		// 
		// TitleLabel
		// 
		TitleLabel.AutoSize = true;
		TitleLabel.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		TitleLabel.ForeColor = Color.FromArgb(232, 171, 68);
		TitleLabel.Location = new Point(75, 33);
		TitleLabel.Name = "TitleLabel";
		TitleLabel.Size = new Size(181, 27);
		TitleLabel.TabIndex = 18;
		TitleLabel.Text = "Назва послуги";
		// 
		// TitleTextBox
		// 
		TitleTextBox.AllowDrop = true;
		TitleTextBox.BackColor = Color.FromArgb(33, 33, 33);
		TitleTextBox.BorderStyle = BorderStyle.FixedSingle;
		TitleTextBox.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		TitleTextBox.ForeColor = Color.FromArgb(232, 171, 68);
		TitleTextBox.Location = new Point(75, 75);
		TitleTextBox.Name = "TitleTextBox";
		TitleTextBox.Size = new Size(829, 34);
		TitleTextBox.TabIndex = 17;
		// 
		// NewRecordButton
		// 
		NewRecordButton.FlatStyle = FlatStyle.Flat;
		NewRecordButton.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		NewRecordButton.ForeColor = Color.FromArgb(232, 171, 68);
		NewRecordButton.Location = new Point(75, 452);
		NewRecordButton.Name = "NewRecordButton";
		NewRecordButton.Size = new Size(233, 67);
		NewRecordButton.TabIndex = 16;
		NewRecordButton.Text = "Оприлюднити купон";
		NewRecordButton.UseVisualStyleBackColor = true;
		NewRecordButton.Click += NewRecordButton_Click;
		// 
		// NewRecordForm
		// 
		AutoScaleDimensions = new SizeF(8F, 20F);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(33, 33, 33);
		ClientSize = new Size(983, 562);
		Controls.Add(DiscountLable);
		Controls.Add(DiscountTextBox);
		Controls.Add(DescriptionLable);
		Controls.Add(DescriptionTextBox);
		Controls.Add(TitleLabel);
		Controls.Add(TitleTextBox);
		Controls.Add(NewRecordButton);
		ForeColor = Color.FromArgb(33, 33, 33);
		MaximizeBox = false;
		Name = "NewRecordForm";
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Label DiscountLable;
	private TextBox DiscountTextBox;
	private Label DescriptionLable;
	private TextBox DescriptionTextBox;
	private Label TitleLabel;
	private TextBox TitleTextBox;
	private Button NewRecordButton;
}