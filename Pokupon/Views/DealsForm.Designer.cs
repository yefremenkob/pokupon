namespace Pokupon.Views;

partial class DealsForm
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
		components = new System.ComponentModel.Container();
		dbServiceBindingSource = new BindingSource(components);
		newRecordButton = new Button();
		exportButton = new Button();
		saveAsJsonDialog = new SaveFileDialog();
		SearchLabel = new Label();
		SearchByTitleTextBox = new TextBox();
		label1 = new Label();
		SearchByDescriptionTextBox = new TextBox();
		label2 = new Label();
		SearchByDiscountTextBox = new TextBox();
		splitContainer1 = new SplitContainer();
		DealsDataGridView = new DataGridView();
		dealBindingSource = new BindingSource(components);
		DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
		((System.ComponentModel.ISupportInitialize)dbServiceBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
		splitContainer1.Panel1.SuspendLayout();
		splitContainer1.Panel2.SuspendLayout();
		splitContainer1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)DealsDataGridView).BeginInit();
		((System.ComponentModel.ISupportInitialize)dealBindingSource).BeginInit();
		SuspendLayout();
		// 
		// dbServiceBindingSource
		// 
		dbServiceBindingSource.DataSource = typeof(DataAccess.DbService);
		// 
		// newRecordButton
		// 
		newRecordButton.FlatStyle = FlatStyle.Flat;
		newRecordButton.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		newRecordButton.ForeColor = Color.FromArgb(232, 171, 68);
		newRecordButton.Location = new Point(58, 734);
		newRecordButton.Name = "newRecordButton";
		newRecordButton.Size = new Size(480, 64);
		newRecordButton.TabIndex = 1;
		newRecordButton.Text = "Створити нову заяву";
		newRecordButton.UseVisualStyleBackColor = true;
		newRecordButton.Click += NewRecordButton_Click;
		// 
		// exportButton
		// 
		exportButton.FlatStyle = FlatStyle.Flat;
		exportButton.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		exportButton.ForeColor = Color.FromArgb(232, 171, 68);
		exportButton.Location = new Point(58, 835);
		exportButton.Name = "exportButton";
		exportButton.Size = new Size(480, 60);
		exportButton.TabIndex = 2;
		exportButton.Text = "Скачати всі купони у форматі json";
		exportButton.UseVisualStyleBackColor = true;
		exportButton.Click += ExportButton_Click;
		// 
		// SearchLabel
		// 
		SearchLabel.AutoEllipsis = true;
		SearchLabel.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		SearchLabel.ForeColor = Color.FromArgb(232, 171, 68);
		SearchLabel.Location = new Point(73, 132);
		SearchLabel.Name = "SearchLabel";
		SearchLabel.RightToLeft = RightToLeft.No;
		SearchLabel.Size = new Size(230, 60);
		SearchLabel.TabIndex = 20;
		SearchLabel.Text = "Шукати за назвою";
		SearchLabel.TextAlign = ContentAlignment.MiddleCenter;
		// 
		// SearchByTitleTextBox
		// 
		SearchByTitleTextBox.BackColor = Color.FromArgb(33, 33, 33);
		SearchByTitleTextBox.BorderStyle = BorderStyle.FixedSingle;
		SearchByTitleTextBox.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		SearchByTitleTextBox.ForeColor = Color.FromArgb(232, 171, 68);
		SearchByTitleTextBox.Location = new Point(58, 208);
		SearchByTitleTextBox.Name = "SearchByTitleTextBox";
		SearchByTitleTextBox.Size = new Size(480, 34);
		SearchByTitleTextBox.TabIndex = 19;
		SearchByTitleTextBox.TextChanged += SearchByTitleTextBoxTextChanged;
		// 
		// label1
		// 
		label1.AutoEllipsis = true;
		label1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		label1.ForeColor = Color.FromArgb(232, 171, 68);
		label1.Location = new Point(63, 256);
		label1.Name = "label1";
		label1.RightToLeft = RightToLeft.No;
		label1.Size = new Size(247, 60);
		label1.TabIndex = 22;
		label1.Text = "Шукати за описом";
		label1.TextAlign = ContentAlignment.MiddleCenter;
		// 
		// SearchByDescriptionTextBox
		// 
		SearchByDescriptionTextBox.BackColor = Color.FromArgb(33, 33, 33);
		SearchByDescriptionTextBox.BorderStyle = BorderStyle.FixedSingle;
		SearchByDescriptionTextBox.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		SearchByDescriptionTextBox.ForeColor = Color.FromArgb(232, 171, 68);
		SearchByDescriptionTextBox.Location = new Point(58, 339);
		SearchByDescriptionTextBox.Name = "SearchByDescriptionTextBox";
		SearchByDescriptionTextBox.Size = new Size(480, 34);
		SearchByDescriptionTextBox.TabIndex = 21;
		SearchByDescriptionTextBox.TextChanged += SearchByDescriptionTextBox_TextChanged;
		// 
		// label2
		// 
		label2.AutoEllipsis = true;
		label2.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		label2.ForeColor = Color.FromArgb(232, 171, 68);
		label2.Location = new Point(58, 400);
		label2.Name = "label2";
		label2.RightToLeft = RightToLeft.No;
		label2.Size = new Size(381, 54);
		label2.TabIndex = 24;
		label2.Text = "Шукати за відсотком знижки";
		label2.TextAlign = ContentAlignment.MiddleCenter;
		// 
		// SearchByDiscountTextBox
		// 
		SearchByDiscountTextBox.BackColor = Color.FromArgb(33, 33, 33);
		SearchByDiscountTextBox.BorderStyle = BorderStyle.FixedSingle;
		SearchByDiscountTextBox.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
		SearchByDiscountTextBox.ForeColor = Color.FromArgb(232, 171, 68);
		SearchByDiscountTextBox.Location = new Point(58, 480);
		SearchByDiscountTextBox.Name = "SearchByDiscountTextBox";
		SearchByDiscountTextBox.Size = new Size(480, 34);
		SearchByDiscountTextBox.TabIndex = 23;
		SearchByDiscountTextBox.TextChanged += SearchByDiscountTextBox_TextChanged;
		// 
		// splitContainer1
		// 
		splitContainer1.Dock = DockStyle.Fill;
		splitContainer1.Location = new Point(0, 0);
		splitContainer1.Name = "splitContainer1";
		// 
		// splitContainer1.Panel1
		// 
		splitContainer1.Panel1.Controls.Add(exportButton);
		splitContainer1.Panel1.Controls.Add(label2);
		splitContainer1.Panel1.Controls.Add(newRecordButton);
		splitContainer1.Panel1.Controls.Add(SearchByDiscountTextBox);
		splitContainer1.Panel1.Controls.Add(SearchByTitleTextBox);
		splitContainer1.Panel1.Controls.Add(label1);
		splitContainer1.Panel1.Controls.Add(SearchLabel);
		splitContainer1.Panel1.Controls.Add(SearchByDescriptionTextBox);
		// 
		// splitContainer1.Panel2
		// 
		splitContainer1.Panel2.Controls.Add(DealsDataGridView);
		splitContainer1.Size = new Size(1848, 954);
		splitContainer1.SplitterDistance = 611;
		splitContainer1.TabIndex = 25;
		// 
		// DealsDataGridView
		// 
		DealsDataGridView.AllowUserToAddRows = false;
		DealsDataGridView.AllowUserToDeleteRows = false;
		DealsDataGridView.AllowUserToResizeRows = false;
		DealsDataGridView.BackgroundColor = Color.FromArgb(33, 33, 33);
		DealsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		DealsDataGridView.DataBindings.Add(new Binding("DataContext", dealBindingSource, "Description", true));
		DealsDataGridView.Dock = DockStyle.Fill;
		DealsDataGridView.Location = new Point(0, 0);
		DealsDataGridView.Name = "DealsDataGridView";
		DealsDataGridView.RowHeadersWidth = 51;
		DealsDataGridView.RowTemplate.Height = 29;
		DealsDataGridView.Size = new Size(1233, 954);
		DealsDataGridView.TabIndex = 0;
		DealsDataGridView.AllowUserToAddRows = false;
		DealsDataGridView.AllowUserToDeleteRows = false;
		DealsDataGridView.AllowUserToResizeRows = false;
		dataGridViewCellStyle9.BackColor = Color.FromArgb(33, 33, 33);
		dataGridViewCellStyle9.ForeColor = Color.FromArgb(232, 171, 68);
		DealsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
		DealsDataGridView.BackgroundColor = Color.FromArgb(33, 33, 33);
		DealsDataGridView.BorderStyle = BorderStyle.None;
		DealsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
		DealsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle10.BackColor = Color.FromArgb(232, 171, 68);
		dataGridViewCellStyle10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
		dataGridViewCellStyle10.ForeColor = Color.FromArgb(33, 33, 33);
		dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
		
		DealsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
		
		
		dataGridViewCellStyle11.BackColor = Color.FromArgb(33, 33, 33);
		dataGridViewCellStyle11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
		dataGridViewCellStyle11.ForeColor = Color.FromArgb(33, 33, 33);
		dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(232, 171, 68);
		dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(33, 33, 33);
		dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
		DealsDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
		DealsDataGridView.EnableHeadersVisualStyles = false;
		DealsDataGridView.GridColor = Color.FromArgb(232, 171, 68);
		
		DealsDataGridView.MultiSelect = false;
		
		DealsDataGridView.RowHeadersVisible = false;
		
		dataGridViewCellStyle12.BackColor = Color.FromArgb(33, 33, 33);
		dataGridViewCellStyle12.ForeColor = Color.FromArgb(232, 171, 68);
		DealsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
		DealsDataGridView.RowTemplate.Height = 40;
		DealsDataGridView.CellDoubleClick += DealsDataGridView_CellDoubleClick;
		// 
		// dealBindingSource
		// 
		dealBindingSource.DataSource = typeof(Models.Deal);
		// 
		// DealsForm
		// 
		AutoScaleDimensions = new SizeF(8F, 20F);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(33, 33, 33);
		ClientSize = new Size(1848, 954);
		Controls.Add(splitContainer1);
		ForeColor = Color.FromArgb(33, 33, 33);
		MinimumSize = new Size(600, 300);
		Name = "DealsForm";
		SizeGripStyle = SizeGripStyle.Hide;
		WindowState = FormWindowState.Maximized;
		((System.ComponentModel.ISupportInitialize)dbServiceBindingSource).EndInit();
		splitContainer1.Panel1.ResumeLayout(false);
		splitContainer1.Panel1.PerformLayout();
		splitContainer1.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
		splitContainer1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)DealsDataGridView).EndInit();
		((System.ComponentModel.ISupportInitialize)dealBindingSource).EndInit();
		ResumeLayout(false);
	}

	#endregion
	private Button exportButton;
	public Button newRecordButton;
	private SaveFileDialog saveAsJsonDialog;
	private Label SearchLabel;
	private TextBox SearchByTitleTextBox;
	private Label label1;
	private TextBox SearchByDescriptionTextBox;
	private Label label2;
	private TextBox SearchByDiscountTextBox;
	private SplitContainer splitContainer1;
	private BindingSource dbServiceBindingSource;
	private DataGridView DealsDataGridView;
	private BindingSource dealBindingSource;
}