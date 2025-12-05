namespace Skedula.Library.Gui.Controls
{
	partial class SkedTreeControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkedTreeControl));
			this._tlpUserControl = new TableLayoutPanel();
			this._tvSkedTree = new TreeView();
			this._ilIcons = new ImageList(this.components);
			this._cmsSkedTree = new ContextMenuStrip(this.components);
			this._tlpUserControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// _tlpUserControl
			// 
			this._tlpUserControl.BackColor = SystemColors.Control;
			this._tlpUserControl.ColumnCount = 1;
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			this._tlpUserControl.Controls.Add(this._tvSkedTree, 0, 0);
			this._tlpUserControl.Dock = DockStyle.Fill;
			this._tlpUserControl.ForeColor = SystemColors.WindowText;
			this._tlpUserControl.Location = new Point(0, 0);
			this._tlpUserControl.Margin = new Padding(0);
			this._tlpUserControl.Name = "_tlpUserControl";
			this._tlpUserControl.RowCount = 1;
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			this._tlpUserControl.Size = new Size(320, 400);
			this._tlpUserControl.TabIndex = 0;
			// 
			// _tvSkedTree
			// 
			this._tvSkedTree.Dock = DockStyle.Fill;
			this._tvSkedTree.FullRowSelect = true;
			this._tvSkedTree.HideSelection = false;
			this._tvSkedTree.ImageIndex = 0;
			this._tvSkedTree.ImageList = this._ilIcons;
			this._tvSkedTree.Location = new Point(0, 0);
			this._tvSkedTree.Margin = new Padding(0);
			this._tvSkedTree.Name = "_tvSkedTree";
			this._tvSkedTree.SelectedImageIndex = 0;
			this._tvSkedTree.ShowLines = false;
			this._tvSkedTree.ShowNodeToolTips = true;
			this._tvSkedTree.Size = new Size(320, 400);
			this._tvSkedTree.TabIndex = 0;
			this._tvSkedTree.AfterSelect += this.SelectedNodeChanged;
			// 
			// _ilIcons
			// 
			this._ilIcons.ColorDepth = ColorDepth.Depth32Bit;
			this._ilIcons.ImageStream = (ImageListStreamer)resources.GetObject("_ilIcons.ImageStream");
			this._ilIcons.TransparentColor = Color.Transparent;
			this._ilIcons.Images.SetKeyName(0, "framework");
			// 
			// _cmsSkedTree
			// 
			this._cmsSkedTree.ImageScalingSize = new Size(20, 20);
			this._cmsSkedTree.Name = "_cmsSkedTree";
			this._cmsSkedTree.Size = new Size(61, 4);
			// 
			// SkedTreeControl
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(0, 48, 96);
			this.Controls.Add(this._tlpUserControl);
			this.Font = new Font("Consolas", 10F);
			this.ForeColor = Color.White;
			this.Margin = new Padding(0);
			this.Name = "SkedTreeControl";
			this.Size = new Size(320, 400);
			this._tlpUserControl.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel _tlpUserControl;
		private TreeView _tvSkedTree;
		private ContextMenuStrip _cmsSkedTree;
		private ImageList _ilIcons;
	}
}
