namespace Skedula.Library.Gui.Controls
{
	partial class SkedNodeControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this._tlpUserControl = new TableLayoutPanel();
			this.label1 = new Label();
			this.label2 = new Label();
			this.label3 = new Label();
			this.label4 = new Label();
			this.label5 = new Label();
			this._txTitle = new TextBox();
			this._cxPriority = new ComboBox();
			this._cxStatus = new ComboBox();
			this._rxDescription = new RichTextBox();
			this._cxIcons = new ImageComboBox();
			this._ilIcons = new ImageList(this.components);
			this._tlpUserControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// _tlpUserControl
			// 
			this._tlpUserControl.BackColor = SystemColors.Control;
			this._tlpUserControl.ColumnCount = 2;
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			this._tlpUserControl.Controls.Add(this.label1, 0, 0);
			this._tlpUserControl.Controls.Add(this.label2, 0, 1);
			this._tlpUserControl.Controls.Add(this.label3, 0, 2);
			this._tlpUserControl.Controls.Add(this.label4, 0, 3);
			this._tlpUserControl.Controls.Add(this.label5, 0, 4);
			this._tlpUserControl.Controls.Add(this._txTitle, 1, 0);
			this._tlpUserControl.Controls.Add(this._cxPriority, 1, 2);
			this._tlpUserControl.Controls.Add(this._cxStatus, 1, 3);
			this._tlpUserControl.Controls.Add(this._rxDescription, 1, 1);
			this._tlpUserControl.Controls.Add(this._cxIcons, 1, 4);
			this._tlpUserControl.Dock = DockStyle.Fill;
			this._tlpUserControl.ForeColor = SystemColors.WindowText;
			this._tlpUserControl.Location = new Point(0, 0);
			this._tlpUserControl.Margin = new Padding(0);
			this._tlpUserControl.Name = "_tlpUserControl";
			this._tlpUserControl.RowCount = 6;
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			this._tlpUserControl.RowStyles.Add(new RowStyle());
			this._tlpUserControl.Size = new Size(320, 400);
			this._tlpUserControl.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = DockStyle.Fill;
			this.label1.Location = new Point(0, 0);
			this.label1.Margin = new Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(114, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Title";
			this.label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = DockStyle.Fill;
			this.label2.Location = new Point(0, 28);
			this.label2.Margin = new Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new Size(114, 276);
			this.label2.TabIndex = 1;
			this.label2.Text = "Description";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = DockStyle.Fill;
			this.label3.Location = new Point(0, 304);
			this.label3.Margin = new Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new Size(114, 28);
			this.label3.TabIndex = 2;
			this.label3.Text = "Priority";
			this.label3.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = DockStyle.Fill;
			this.label4.Location = new Point(0, 332);
			this.label4.Margin = new Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new Size(114, 28);
			this.label4.TabIndex = 3;
			this.label4.Text = "Status";
			this.label4.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = DockStyle.Fill;
			this.label5.Location = new Point(0, 360);
			this.label5.Margin = new Padding(0);
			this.label5.Name = "label5";
			this.label5.Size = new Size(114, 40);
			this.label5.TabIndex = 4;
			this.label5.Text = "Icon";
			this.label5.TextAlign = ContentAlignment.MiddleRight;
			// 
			// _txTitle
			// 
			this._txTitle.Dock = DockStyle.Fill;
			this._txTitle.Location = new Point(114, 0);
			this._txTitle.Margin = new Padding(0);
			this._txTitle.Name = "_txTitle";
			this._txTitle.Size = new Size(206, 27);
			this._txTitle.TabIndex = 5;
			// 
			// _cxPriority
			// 
			this._cxPriority.Dock = DockStyle.Fill;
			this._cxPriority.FormattingEnabled = true;
			this._cxPriority.Location = new Point(114, 304);
			this._cxPriority.Margin = new Padding(0);
			this._cxPriority.Name = "_cxPriority";
			this._cxPriority.Size = new Size(206, 28);
			this._cxPriority.TabIndex = 6;
			// 
			// _cxStatus
			// 
			this._cxStatus.Dock = DockStyle.Fill;
			this._cxStatus.FormattingEnabled = true;
			this._cxStatus.Location = new Point(114, 332);
			this._cxStatus.Margin = new Padding(0);
			this._cxStatus.Name = "_cxStatus";
			this._cxStatus.Size = new Size(206, 28);
			this._cxStatus.TabIndex = 7;
			// 
			// _rxDescription
			// 
			this._rxDescription.Dock = DockStyle.Fill;
			this._rxDescription.Location = new Point(114, 28);
			this._rxDescription.Margin = new Padding(0);
			this._rxDescription.Name = "_rxDescription";
			this._rxDescription.Size = new Size(206, 276);
			this._rxDescription.TabIndex = 9;
			this._rxDescription.Text = "";
			// 
			// _cxIcons
			// 
			this._cxIcons.Dock = DockStyle.Fill;
			this._cxIcons.DrawMode = DrawMode.OwnerDrawFixed;
			this._cxIcons.DropDownStyle = ComboBoxStyle.DropDownList;
			this._cxIcons.FormattingEnabled = true;
			this._cxIcons.ItemHeight = 20;
			this._cxIcons.Location = new Point(114, 360);
			this._cxIcons.Margin = new Padding(0);
			this._cxIcons.Name = "_cxIcons";
			this._cxIcons.Size = new Size(206, 26);
			this._cxIcons.TabIndex = 10;
			// 
			// _ilIcons
			// 
			this._ilIcons.ColorDepth = ColorDepth.Depth32Bit;
			this._ilIcons.ImageSize = new Size(16, 16);
			this._ilIcons.TransparentColor = Color.Transparent;
			// 
			// SkedNodeControl
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(0, 48, 96);
			this.Controls.Add(this._tlpUserControl);
			this.Font = new Font("Consolas", 10F);
			this.ForeColor = Color.White;
			this.Margin = new Padding(0);
			this.Name = "SkedNodeControl";
			this.Size = new Size(320, 400);
			this._tlpUserControl.ResumeLayout(false);
			this._tlpUserControl.PerformLayout();
			this.ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel _tlpUserControl;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox _txTitle;
		private ComboBox _cxPriority;
		private ComboBox _cxStatus;
		private ImageList _ilIcons;
		private RichTextBox _rxDescription;
		private ImageComboBox _cxIcons;
	}
}
