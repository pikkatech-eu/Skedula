/***********************************************************************************
* File:         SkedulaForm.cs                                                     *
* Contents:     Class SkedulaForm                                                  *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-12-04 17:52                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Skedula.Library.Domain;
using BSM = Skedula.Library.Management.BasicSkedulaManager;


namespace Skedula
{
	public partial class SkedulaForm : Form
	{
		public SkedulaForm()
		{
			InitializeComponent();

			BSM.Instance.Settings.RecentlyOpenedProjectsChanged += this.OnRecentlyOpenedProjectsChanged;

			BSM.Instance.SkedTreeChanged += this.OnSkedTreeChanged;
			Factotum.Versioning.Version version = new Factotum.Versioning.Version();
			version.FromToml();

			this.Text = $"Skedula {version}";

			this.OnRecentlyOpenedProjectsChanged(BSM.Instance.Settings.RecentlyOpenedProjects);

			this._ctrlSkedTree.SkedSelected += this.OnSkedSelected;

			if (BSM.Instance.Settings.AutoLoadLastProject && BSM.Instance.Settings.RecentlyOpenedProjects.Count > 0)
			{
				BSM.Instance.LoadSkedTree(BSM.Instance.Settings.RecentlyOpenedProjects[0]);
			}
		}

		private void OnRecentlyOpenedProjectsChanged(List<string> paths)
		{
			List<ToolStripItem> items = new List<ToolStripItem>();

			this._menuItemRecentProjects.DropDownItems.Clear();

			foreach (string path in paths)
			{
				ToolStripItem item = this._menuItemRecentProjects.DropDownItems.Add(path);

				item.Click += this.RecentlyOpenedItemClicked;

				items.Add(item);
			}
		}

		private void RecentlyOpenedItemClicked(object? sender, EventArgs e)
		{
			string filePath = ((ToolStripItem)sender).Text;

			if (File.Exists(filePath))
			{
				BSM.Instance.LoadSkedTree(filePath);
			}
			else
			{
				BSM.Instance.Settings.RemoveRecentlyOpenedProject(filePath);
			}
		}

		private void OnSkedSelected(SkedNode skedNode)
		{
			this._ctrlExtendedSkedNode.SkedNode = skedNode;
		}

		private void OnSkedTreeChanged(SkedTree skedTree)
		{
			this._ctrlSkedTree.Display(skedTree);
		}

		#region SkedTree management
		private void OnFileQuit(object sender, EventArgs e)
		{
			if (this.CanClose())
			{
				this.Close();
			}
		}

		private void OnFileNewSkedTree(object sender, EventArgs e)
		{
			BSM.Instance.NewSkedTree();
		}

		private void OnFileLoadSkedTree(object sender, EventArgs e)
		{
			BSM.Instance.LoadSkedTree();
		}
		#endregion

		#region Private Auxiliary
		private bool CanClose()
		{
			return true;
		}
		#endregion

		private void OnFileSaveSkedTreeAs(object sender, EventArgs e)
		{
			BSM.Instance.SaveSkedTreeAs();
		}

		private void OnSkedAdd(object sender, EventArgs e)
		{
			BSM.Instance.AddSkedNode();
		}

		private void OnSkedEdit(object sender, EventArgs e)
		{
			BSM.Instance.ReplaceSkedNode();
		}

		private void OnSkedDelete(object sender, EventArgs e)
		{
			BSM.Instance.DeleteSkedNode();
		}

		private void OnFileEditSkedTree(object sender, EventArgs e)
		{
			BSM.Instance.EditSkedTree();
		}

		private void OnSkedAddRootNode(object sender, EventArgs e)
		{
			BSM.Instance.AddSkedNode(true);
		}
	}
}
