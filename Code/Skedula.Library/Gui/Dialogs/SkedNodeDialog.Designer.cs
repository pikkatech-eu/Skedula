namespace Skedula.Library.Gui.Dialogs
{
	partial class SkedNodeDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkedNodeDialog));
			this._btOK = new Button();
			this._btCancel = new Button();
			this._ctrlSkedNode = new Skedula.Library.Gui.Controls.SkedNodeControl();
			this.SuspendLayout();
			// 
			// _btOK
			// 
			this._btOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this._btOK.BackColor = SystemColors.Control;
			this._btOK.DialogResult = DialogResult.OK;
			this._btOK.Location = new Point(9, 347);
			this._btOK.Margin = new Padding(0);
			this._btOK.Name = "_btOK";
			this._btOK.Size = new Size(80, 32);
			this._btOK.TabIndex = 0;
			this._btOK.Text = "OK";
			this._btOK.UseVisualStyleBackColor = false;
			// 
			// _btCancel
			// 
			this._btCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this._btCancel.BackColor = SystemColors.Control;
			this._btCancel.DialogResult = DialogResult.Cancel;
			this._btCancel.Location = new Point(114, 347);
			this._btCancel.Margin = new Padding(0);
			this._btCancel.Name = "_btCancel";
			this._btCancel.Size = new Size(80, 32);
			this._btCancel.TabIndex = 0;
			this._btCancel.Text = "Cancel";
			this._btCancel.UseVisualStyleBackColor = false;
			// 
			// _ctrlSkedNode
			// 
			this._ctrlSkedNode.BackColor = Color.FromArgb(0, 48, 96);
			this._ctrlSkedNode.Dock = DockStyle.Top;
			this._ctrlSkedNode.Font = new Font("Consolas", 10F);
			this._ctrlSkedNode.ForeColor = Color.White;
			this._ctrlSkedNode.Location = new Point(0, 0);
			this._ctrlSkedNode.Margin = new Padding(0);
			this._ctrlSkedNode.Name = "_ctrlSkedNode";
			this._ctrlSkedNode.Size = new Size(529, 324);
			this._ctrlSkedNode.TabIndex = 1;
			// 
			// SkedNodeDialog
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			this.ClientSize = new Size(529, 388);
			this.Controls.Add(this._ctrlSkedNode);
			this.Controls.Add(this._btCancel);
			this.Controls.Add(this._btOK);
			this.Font = new Font("Consolas", 10F);
			this.ForeColor = SystemColors.WindowText;
			this.Icon = (Icon)resources.GetObject("$this.Icon");
			this.Name = "SkedNodeDialog";
			this.Text = "Sked Node Properties";
			this.ResumeLayout(false);
		}

		#endregion

		private Button _btOK;
		private Button _btCancel;
		private Controls.SkedNodeControl _ctrlSkedNode;
	}
}