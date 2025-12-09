namespace Skedula
{
	partial class SkedulaForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkedulaForm));
			this._msSkedula = new MenuStrip();
			this.fToolStripMenuItem = new ToolStripMenuItem();
			this.newSkedTreeToolStripMenuItem = new ToolStripMenuItem();
			this.editSkedTreeToolStripMenuItem = new ToolStripMenuItem();
			this.loadSkedTreeToolStripMenuItem = new ToolStripMenuItem();
			this.saveSkedTreeAsToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.quitToolStripMenuItem = new ToolStripMenuItem();
			this.skedToolStripMenuItem = new ToolStripMenuItem();
			this.addToolStripMenuItem = new ToolStripMenuItem();
			this.editToolStripMenuItem = new ToolStripMenuItem();
			this.deleteToolStripMenuItem = new ToolStripMenuItem();
			this.toolsToolStripMenuItem = new ToolStripMenuItem();
			this.settingsToolStripMenuItem = new ToolStripMenuItem();
			this.helpToolStripMenuItem = new ToolStripMenuItem();
			this.aboutToolStripMenuItem = new ToolStripMenuItem();
			this._tsSkedula = new ToolStrip();
			this._stsSkedula = new StatusStrip();
			this._scSkedula = new SplitContainer();
			this._ctrlSkedTree = new Skedula.Library.Gui.Controls.SkedTreeControl();
			this._btLoad = new ToolStripButton();
			this._btSave = new ToolStripButton();
			this.toolStripButton1 = new ToolStripButton();
			this.toolStripButton2 = new ToolStripButton();
			this.toolStripButton3 = new ToolStripButton();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this._msSkedula.SuspendLayout();
			this._tsSkedula.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this._scSkedula).BeginInit();
			this._scSkedula.Panel1.SuspendLayout();
			this._scSkedula.SuspendLayout();
			this.SuspendLayout();
			// 
			// _msSkedula
			// 
			this._msSkedula.Font = new Font("Consolas", 10F);
			this._msSkedula.ImageScalingSize = new Size(20, 20);
			this._msSkedula.Items.AddRange(new ToolStripItem[] { this.fToolStripMenuItem, this.skedToolStripMenuItem, this.toolsToolStripMenuItem, this.helpToolStripMenuItem });
			this._msSkedula.Location = new Point(0, 0);
			this._msSkedula.Name = "_msSkedula";
			this._msSkedula.Size = new Size(1294, 28);
			this._msSkedula.TabIndex = 0;
			this._msSkedula.Text = "menuStrip1";
			// 
			// fToolStripMenuItem
			// 
			this.fToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.newSkedTreeToolStripMenuItem, this.editSkedTreeToolStripMenuItem, this.loadSkedTreeToolStripMenuItem, this.saveSkedTreeAsToolStripMenuItem, this.toolStripSeparator1, this.quitToolStripMenuItem });
			this.fToolStripMenuItem.Font = new Font("Consolas", 10F);
			this.fToolStripMenuItem.Name = "fToolStripMenuItem";
			this.fToolStripMenuItem.Size = new Size(59, 24);
			this.fToolStripMenuItem.Text = "&File";
			// 
			// newSkedTreeToolStripMenuItem
			// 
			this.newSkedTreeToolStripMenuItem.Name = "newSkedTreeToolStripMenuItem";
			this.newSkedTreeToolStripMenuItem.Size = new Size(236, 26);
			this.newSkedTreeToolStripMenuItem.Text = "&New Sked Tree";
			this.newSkedTreeToolStripMenuItem.Click += this.OnFileNewSkedTree;
			// 
			// editSkedTreeToolStripMenuItem
			// 
			this.editSkedTreeToolStripMenuItem.Name = "editSkedTreeToolStripMenuItem";
			this.editSkedTreeToolStripMenuItem.Size = new Size(236, 26);
			this.editSkedTreeToolStripMenuItem.Text = "&Edit Sked Tree";
			this.editSkedTreeToolStripMenuItem.Click += this.OnFileEditSkedTree;
			// 
			// loadSkedTreeToolStripMenuItem
			// 
			this.loadSkedTreeToolStripMenuItem.Name = "loadSkedTreeToolStripMenuItem";
			this.loadSkedTreeToolStripMenuItem.Size = new Size(236, 26);
			this.loadSkedTreeToolStripMenuItem.Text = "&Load Sked Tree";
			this.loadSkedTreeToolStripMenuItem.Click += this.OnFileLoadSkedTree;
			// 
			// saveSkedTreeAsToolStripMenuItem
			// 
			this.saveSkedTreeAsToolStripMenuItem.Name = "saveSkedTreeAsToolStripMenuItem";
			this.saveSkedTreeAsToolStripMenuItem.Size = new Size(236, 26);
			this.saveSkedTreeAsToolStripMenuItem.Text = "&Save SkedTree &As";
			this.saveSkedTreeAsToolStripMenuItem.Click += this.OnFileSaveSkedTreeAs;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(233, 6);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new Size(236, 26);
			this.quitToolStripMenuItem.Text = "&Quit";
			this.quitToolStripMenuItem.Click += this.OnFileQuit;
			// 
			// skedToolStripMenuItem
			// 
			this.skedToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.addToolStripMenuItem, this.editToolStripMenuItem, this.deleteToolStripMenuItem });
			this.skedToolStripMenuItem.Font = new Font("Consolas", 10F);
			this.skedToolStripMenuItem.Name = "skedToolStripMenuItem";
			this.skedToolStripMenuItem.Size = new Size(59, 24);
			this.skedToolStripMenuItem.Text = "&Sked";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new Size(146, 26);
			this.addToolStripMenuItem.Text = "&Add";
			this.addToolStripMenuItem.Click += this.OnSkedAdd;
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new Size(146, 26);
			this.editToolStripMenuItem.Text = "&Edit";
			this.editToolStripMenuItem.Click += this.OnSkedEdit;
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new Size(146, 26);
			this.deleteToolStripMenuItem.Text = "&Delete";
			this.deleteToolStripMenuItem.Click += this.OnSkedDelete;
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.settingsToolStripMenuItem });
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new Size(68, 24);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new Size(164, 26);
			this.settingsToolStripMenuItem.Text = "&Settings";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.aboutToolStripMenuItem });
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new Size(59, 24);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new Size(137, 26);
			this.aboutToolStripMenuItem.Text = "&About";
			// 
			// _tsSkedula
			// 
			this._tsSkedula.AutoSize = false;
			this._tsSkedula.ImageScalingSize = new Size(20, 20);
			this._tsSkedula.Items.AddRange(new ToolStripItem[] { this.toolStripButton3, this._btLoad, this._btSave, this.toolStripButton1, this.toolStripButton2, this.toolStripSeparator2 });
			this._tsSkedula.Location = new Point(0, 28);
			this._tsSkedula.Name = "_tsSkedula";
			this._tsSkedula.Size = new Size(1294, 40);
			this._tsSkedula.TabIndex = 1;
			this._tsSkedula.Text = "toolStrip1";
			// 
			// _stsSkedula
			// 
			this._stsSkedula.ImageScalingSize = new Size(20, 20);
			this._stsSkedula.Location = new Point(0, 697);
			this._stsSkedula.Name = "_stsSkedula";
			this._stsSkedula.Size = new Size(1294, 22);
			this._stsSkedula.TabIndex = 2;
			this._stsSkedula.Text = "statusStrip1";
			// 
			// _scSkedula
			// 
			this._scSkedula.Dock = DockStyle.Fill;
			this._scSkedula.Location = new Point(0, 68);
			this._scSkedula.Margin = new Padding(0);
			this._scSkedula.Name = "_scSkedula";
			// 
			// _scSkedula.Panel1
			// 
			this._scSkedula.Panel1.Controls.Add(this._ctrlSkedTree);
			this._scSkedula.Size = new Size(1294, 629);
			this._scSkedula.SplitterDistance = 653;
			this._scSkedula.TabIndex = 3;
			// 
			// _ctrlSkedTree
			// 
			this._ctrlSkedTree.BackColor = Color.FromArgb(0, 48, 96);
			this._ctrlSkedTree.Dock = DockStyle.Fill;
			this._ctrlSkedTree.Font = new Font("Consolas", 10F);
			this._ctrlSkedTree.ForeColor = Color.White;
			this._ctrlSkedTree.Location = new Point(0, 0);
			this._ctrlSkedTree.Margin = new Padding(0);
			this._ctrlSkedTree.Name = "_ctrlSkedTree";
			this._ctrlSkedTree.Size = new Size(653, 629);
			this._ctrlSkedTree.TabIndex = 0;
			// 
			// _btLoad
			// 
			this._btLoad.AutoSize = false;
			this._btLoad.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this._btLoad.Image = Properties.Resources.collection_load;
			this._btLoad.ImageScaling = ToolStripItemImageScaling.None;
			this._btLoad.ImageTransparentColor = Color.Magenta;
			this._btLoad.Name = "_btLoad";
			this._btLoad.Size = new Size(37, 37);
			this._btLoad.Text = "toolStripButton1";
			this._btLoad.Click += this.OnFileLoadSkedTree;
			// 
			// _btSave
			// 
			this._btSave.AutoSize = false;
			this._btSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this._btSave.Image = Properties.Resources.collection_save;
			this._btSave.ImageScaling = ToolStripItemImageScaling.None;
			this._btSave.ImageTransparentColor = Color.Magenta;
			this._btSave.Name = "_btSave";
			this._btSave.Size = new Size(37, 37);
			this._btSave.Text = "toolStripButton2";
			this._btSave.Click += this.OnFileSaveSkedTreeAs;
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = Properties.Resources.configuration;
			this.toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
			this.toolStripButton1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new Size(34, 37);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.Alignment = ToolStripItemAlignment.Right;
			this.toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = Properties.Resources.quit;
			this.toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
			this.toolStripButton2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new Size(34, 37);
			this.toolStripButton2.Text = "toolStripButton2";
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = Properties.Resources.tree_32;
			this.toolStripButton3.ImageTransparentColor = Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new Size(29, 37);
			this.toolStripButton3.Text = "toolStripButton3";
			this.toolStripButton3.Click += this.OnFileNewSkedTree;
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(6, 40);
			// 
			// SkedulaForm
			// 
			this.AutoScaleDimensions = new SizeF(10F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(1294, 719);
			this.Controls.Add(this._scSkedula);
			this.Controls.Add(this._stsSkedula);
			this.Controls.Add(this._tsSkedula);
			this.Controls.Add(this._msSkedula);
			this.Font = new Font("Microsoft Sans Serif", 10F);
			this.Icon = (Icon)resources.GetObject("$this.Icon");
			this.MainMenuStrip = this._msSkedula;
			this.Margin = new Padding(4, 3, 4, 3);
			this.Name = "SkedulaForm";
			this.Text = "Skedula 1.0.0";
			this.WindowState = FormWindowState.Maximized;
			this._msSkedula.ResumeLayout(false);
			this._msSkedula.PerformLayout();
			this._tsSkedula.ResumeLayout(false);
			this._tsSkedula.PerformLayout();
			this._scSkedula.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this._scSkedula).EndInit();
			this._scSkedula.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private MenuStrip _msSkedula;
		private ToolStrip _tsSkedula;
		private StatusStrip _stsSkedula;
		private ToolStripMenuItem fToolStripMenuItem;
		private ToolStripMenuItem newSkedTreeToolStripMenuItem;
		private ToolStripMenuItem loadSkedTreeToolStripMenuItem;
		private ToolStripMenuItem saveSkedTreeAsToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem quitToolStripMenuItem;
		private ToolStripMenuItem skedToolStripMenuItem;
		private ToolStripMenuItem addToolStripMenuItem;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem deleteToolStripMenuItem;
		private ToolStripMenuItem toolsToolStripMenuItem;
		private ToolStripMenuItem settingsToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem aboutToolStripMenuItem;
		private SplitContainer _scSkedula;
		private Library.Gui.Controls.SkedTreeControl _ctrlSkedTree;
		private ToolStripMenuItem editSkedTreeToolStripMenuItem;
		private ToolStripButton _btLoad;
		private ToolStripButton _btSave;
		private ToolStripButton toolStripButton1;
		private ToolStripButton toolStripButton2;
		private ToolStripButton toolStripButton3;
		private ToolStripSeparator toolStripSeparator2;
	}
}
