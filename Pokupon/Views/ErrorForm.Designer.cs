using System.ComponentModel;

namespace Pokupon.Views;

partial class ErrorForm
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
		label1 = new Label();
		button1 = new Button();
		SuspendLayout();
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
		label1.ForeColor = Color.Red;
		label1.Location = new Point(41, 41);
		label1.Name = "label1";
		label1.Size = new Size(234, 67);
		label1.TabIndex = 0;
		label1.Text = "Помилка";
		// 
		// button1
		// 
		button1.Location = new Point(92, 150);
		button1.Name = "button1";
		button1.Size = new Size(131, 45);
		button1.TabIndex = 1;
		button1.Text = "OK";
		button1.UseVisualStyleBackColor = true;
		button1.Click += Button1_Click;
		// 
		// ErrorForm
		// 
		AutoScaleDimensions = new SizeF(8F, 20F);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = SystemColors.ButtonHighlight;
		ClientSize = new Size(319, 232);
		Controls.Add(button1);
		Controls.Add(label1);
		Name = "ErrorForm";
		Text = "ErrorForm";
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Label label1;
	private Button button1;
}