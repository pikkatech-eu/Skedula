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
			this._cmsSkedTree = new ContextMenuStrip(this.components);
			this.addNodeToolStripMenuItem = new ToolStripMenuItem();
			this.editNodeToolStripMenuItem = new ToolStripMenuItem();
			this.deleteNodeToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.unselectToolStripMenuItem = new ToolStripMenuItem();
			this._ilIcons = new ImageList(this.components);
			this._tlpUserControl.SuspendLayout();
			this._cmsSkedTree.SuspendLayout();
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
			this._tvSkedTree.ContextMenuStrip = this._cmsSkedTree;
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
			// _cmsSkedTree
			// 
			this._cmsSkedTree.Font = new Font("Consolas", 10F);
			this._cmsSkedTree.ImageScalingSize = new Size(20, 20);
			this._cmsSkedTree.Items.AddRange(new ToolStripItem[] { this.addNodeToolStripMenuItem, this.editNodeToolStripMenuItem, this.deleteNodeToolStripMenuItem, this.toolStripSeparator1, this.unselectToolStripMenuItem });
			this._cmsSkedTree.Name = "_cmsSkedTree";
			this._cmsSkedTree.Size = new Size(178, 106);
			// 
			// addNodeToolStripMenuItem
			// 
			this.addNodeToolStripMenuItem.Name = "addNodeToolStripMenuItem";
			this.addNodeToolStripMenuItem.Size = new Size(177, 24);
			this.addNodeToolStripMenuItem.Text = "&Add Node";
			this.addNodeToolStripMenuItem.Click += this.OnNodeAdd;
			// 
			// editNodeToolStripMenuItem
			// 
			this.editNodeToolStripMenuItem.Name = "editNodeToolStripMenuItem";
			this.editNodeToolStripMenuItem.Size = new Size(177, 24);
			this.editNodeToolStripMenuItem.Text = "&Edit Node";
			this.editNodeToolStripMenuItem.Click += this.OnNodeEdit;
			// 
			// deleteNodeToolStripMenuItem
			// 
			this.deleteNodeToolStripMenuItem.Name = "deleteNodeToolStripMenuItem";
			this.deleteNodeToolStripMenuItem.Size = new Size(177, 24);
			this.deleteNodeToolStripMenuItem.Text = "&Delete Node";
			this.deleteNodeToolStripMenuItem.Click += this.OnNodeDelete;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(174, 6);
			// 
			// unselectToolStripMenuItem
			// 
			this.unselectToolStripMenuItem.Name = "unselectToolStripMenuItem";
			this.unselectToolStripMenuItem.Size = new Size(177, 24);
			this.unselectToolStripMenuItem.Text = "&Unselect";
			this.unselectToolStripMenuItem.Click += this.OnUnselect;
			// 
			// _ilIcons
			// 
			this._ilIcons.ColorDepth = ColorDepth.Depth32Bit;
			this._ilIcons.ImageStream = (ImageListStreamer)resources.GetObject("_ilIcons.ImageStream");
			this._ilIcons.TransparentColor = Color.Transparent;
			this._ilIcons.Images.SetKeyName(0, "tree_16");
			this._ilIcons.Images.SetKeyName(1, "leaf_16");
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
			this._cmsSkedTree.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel _tlpUserControl;
		private TreeView _tvSkedTree;
		private ContextMenuStrip _cmsSkedTree;
		private ImageList _ilIcons;
		private ToolStripMenuItem addNodeToolStripMenuItem;
		private ToolStripMenuItem editNodeToolStripMenuItem;
		private ToolStripMenuItem deleteNodeToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem unselectToolStripMenuItem;
	}
}
