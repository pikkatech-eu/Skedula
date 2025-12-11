namespace Skedula.Library.Gui.Controls
{
	partial class ExtendedSkedNodeControl
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
			this._lblDates = new Label();
			this.label1 = new Label();
			this.label2 = new Label();
			this.label3 = new Label();
			this.label4 = new Label();
			this._txTitle = new TextBox();
			this._cxPriority = new ComboBox();
			this._cxStatus = new ComboBox();
			this._rxDescription = new RichTextBox();
			this._pbIcon = new PictureBox();
			this._lblGuid = new Label();
			this._ilIcons = new ImageList(this.components);
			this._tlpUserControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this._pbIcon).BeginInit();
			this.SuspendLayout();
			// 
			// _tlpUserControl
			// 
			this._tlpUserControl.BackColor = SystemColors.Control;
			this._tlpUserControl.ColumnCount = 3;
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 38F));
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			this._tlpUserControl.Controls.Add(this._lblDates, 2, 1);
			this._tlpUserControl.Controls.Add(this.label1, 0, 2);
			this._tlpUserControl.Controls.Add(this.label2, 0, 3);
			this._tlpUserControl.Controls.Add(this.label3, 0, 4);
			this._tlpUserControl.Controls.Add(this.label4, 0, 5);
			this._tlpUserControl.Controls.Add(this._txTitle, 1, 2);
			this._tlpUserControl.Controls.Add(this._cxPriority, 1, 4);
			this._tlpUserControl.Controls.Add(this._cxStatus, 1, 5);
			this._tlpUserControl.Controls.Add(this._rxDescription, 1, 3);
			this._tlpUserControl.Controls.Add(this._pbIcon, 1, 0);
			this._tlpUserControl.Controls.Add(this._lblGuid, 2, 0);
			this._tlpUserControl.Dock = DockStyle.Fill;
			this._tlpUserControl.ForeColor = SystemColors.WindowText;
			this._tlpUserControl.Location = new Point(0, 0);
			this._tlpUserControl.Margin = new Padding(0);
			this._tlpUserControl.Name = "_tlpUserControl";
			this._tlpUserControl.RowCount = 6;
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
			this._tlpUserControl.Size = new Size(839, 675);
			this._tlpUserControl.TabIndex = 0;
			// 
			// _lblDates
			// 
			this._lblDates.AutoSize = true;
			this._lblDates.Dock = DockStyle.Fill;
			this._lblDates.Font = new Font("Consolas", 12F);
			this._lblDates.Location = new Point(151, 38);
			this._lblDates.Name = "_lblDates";
			this._lblDates.Size = new Size(685, 38);
			this._lblDates.TabIndex = 13;
			this._lblDates.Text = "***";
			this._lblDates.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = DockStyle.Fill;
			this.label1.Font = new Font("Consolas", 10F);
			this.label1.Location = new Point(0, 76);
			this.label1.Margin = new Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(110, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "Title";
			this.label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = DockStyle.Fill;
			this.label2.Font = new Font("Consolas", 10F);
			this.label2.Location = new Point(0, 114);
			this.label2.Margin = new Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new Size(110, 485);
			this.label2.TabIndex = 1;
			this.label2.Text = "Description";
			this.label2.TextAlign = ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = DockStyle.Fill;
			this.label3.Font = new Font("Consolas", 10F);
			this.label3.Location = new Point(0, 599);
			this.label3.Margin = new Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new Size(110, 38);
			this.label3.TabIndex = 2;
			this.label3.Text = "Priority";
			this.label3.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = DockStyle.Fill;
			this.label4.Font = new Font("Consolas", 10F);
			this.label4.Location = new Point(0, 637);
			this.label4.Margin = new Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new Size(110, 38);
			this.label4.TabIndex = 3;
			this.label4.Text = "Status";
			this.label4.TextAlign = ContentAlignment.MiddleRight;
			// 
			// _txTitle
			// 
			this._txTitle.BackColor = SystemColors.Window;
			this._tlpUserControl.SetColumnSpan(this._txTitle, 2);
			this._txTitle.Dock = DockStyle.Fill;
			this._txTitle.Location = new Point(110, 76);
			this._txTitle.Margin = new Padding(0);
			this._txTitle.Name = "_txTitle";
			this._txTitle.ReadOnly = true;
			this._txTitle.Size = new Size(729, 35);
			this._txTitle.TabIndex = 5;
			// 
			// _cxPriority
			// 
			this._tlpUserControl.SetColumnSpan(this._cxPriority, 2);
			this._cxPriority.Dock = DockStyle.Fill;
			this._cxPriority.DropDownStyle = ComboBoxStyle.DropDownList;
			this._cxPriority.FormattingEnabled = true;
			this._cxPriority.Location = new Point(110, 599);
			this._cxPriority.Margin = new Padding(0);
			this._cxPriority.Name = "_cxPriority";
			this._cxPriority.Size = new Size(729, 35);
			this._cxPriority.TabIndex = 6;
			// 
			// _cxStatus
			// 
			this._tlpUserControl.SetColumnSpan(this._cxStatus, 2);
			this._cxStatus.Dock = DockStyle.Fill;
			this._cxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
			this._cxStatus.FormattingEnabled = true;
			this._cxStatus.Location = new Point(110, 637);
			this._cxStatus.Margin = new Padding(0);
			this._cxStatus.Name = "_cxStatus";
			this._cxStatus.Size = new Size(729, 35);
			this._cxStatus.TabIndex = 7;
			// 
			// _rxDescription
			// 
			this._rxDescription.BackColor = SystemColors.Window;
			this._tlpUserControl.SetColumnSpan(this._rxDescription, 2);
			this._rxDescription.Dock = DockStyle.Fill;
			this._rxDescription.Location = new Point(110, 114);
			this._rxDescription.Margin = new Padding(0);
			this._rxDescription.Name = "_rxDescription";
			this._rxDescription.ReadOnly = true;
			this._rxDescription.Size = new Size(729, 485);
			this._rxDescription.TabIndex = 9;
			this._rxDescription.Text = "";
			// 
			// _pbIcon
			// 
			this._pbIcon.Dock = DockStyle.Right;
			this._pbIcon.Location = new Point(110, 0);
			this._pbIcon.Margin = new Padding(0);
			this._pbIcon.Name = "_pbIcon";
			this._pbIcon.Size = new Size(38, 38);
			this._pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
			this._pbIcon.TabIndex = 11;
			this._pbIcon.TabStop = false;
			// 
			// _lblGuid
			// 
			this._lblGuid.AutoSize = true;
			this._lblGuid.Dock = DockStyle.Fill;
			this._lblGuid.Font = new Font("Consolas", 12F);
			this._lblGuid.Location = new Point(151, 0);
			this._lblGuid.Name = "_lblGuid";
			this._lblGuid.Size = new Size(685, 38);
			this._lblGuid.TabIndex = 12;
			this._lblGuid.Text = "***";
			this._lblGuid.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// _ilIcons
			// 
			this._ilIcons.ColorDepth = ColorDepth.Depth32Bit;
			this._ilIcons.ImageSize = new Size(16, 16);
			this._ilIcons.TransparentColor = Color.Transparent;
			// 
			// ExtendedSkedNodeControl
			// 
			this.AutoScaleDimensions = new SizeF(13F, 27F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(0, 48, 96);
			this.Controls.Add(this._tlpUserControl);
			this.Font = new Font("Consolas", 14F);
			this.ForeColor = Color.White;
			this.Margin = new Padding(0);
			this.Name = "ExtendedSkedNodeControl";
			this.Size = new Size(839, 675);
			this._tlpUserControl.ResumeLayout(false);
			this._tlpUserControl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this._pbIcon).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel _tlpUserControl;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox _txTitle;
		private ComboBox _cxPriority;
		private ComboBox _cxStatus;
		private ImageList _ilIcons;
		private RichTextBox _rxDescription;
		private PictureBox _pbIcon;
		private Label _lblGuid;
		private Label _lblDates;
	}
}
