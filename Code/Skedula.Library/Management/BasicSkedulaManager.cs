/***********************************************************************************
* File:         BasicSkedulaManager.cs                                             *
* Contents:     Class BasicSkedulaManager                                          *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-12-04 14:36                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Skedula.Library.Domain;
using Skedula.Library.Gui.Dialogs;
using BSM = Skedula.Library.Management.BasicSkedulaManager;

namespace Skedula.Library.Management
{
	public class BasicSkedulaManager : ISkedulaManager
	{
		#region Constants
		internal const string DEFAULT_EXTENSION = "*.sked";
		#endregion

		#region Singletonia
		private static readonly Lazy<BasicSkedulaManager> _instance = new Lazy<BasicSkedulaManager>(() => new BasicSkedulaManager());
		public static BasicSkedulaManager Instance => _instance.Value;
		private BasicSkedulaManager() 
		{
			// Initialization logic here
		}
		#endregion

		#region Private Members
		private string _skedTreeFileName = null;
		#endregion

		#region Properties
		public SkedTree SkedTree		{get;set;}	= null;

		public SkedNode SelectedSkedNode	{get;set;}	= null;

		public Settings Settings		{get;set;}	= null;
		#endregion

		#region Events
		public event Action<SkedTree> SkedTreeChanged;
		#endregion

		#region SkedTree Management
		public void NewSkedTree()
		{
			SkedTreePropertiesDialog dialog = new SkedTreePropertiesDialog();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.SkedTree				= new SkedTree();
				this.SkedTree.Title			= dialog.ItemName;
				this.SkedTree.Description	= dialog.ItemDescription;

				this.SaveSkedTree();
			}
		}

		public void LoadSkedTree(string fileName = null)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = $"Skedula Files ({DEFAULT_EXTENSION})|{DEFAULT_EXTENSION}|All files (*.*)|(*.*)";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this._skedTreeFileName = dialog.FileName;
				this.SkedTree = SkedTree.Load(this._skedTreeFileName);

				this.SkedTreeChanged(this.SkedTree);
			}
		}

		public void SaveSkedTree()
		{
			if (String.IsNullOrEmpty(this._skedTreeFileName))
			{
				this.SaveSkedTreeAs();
			}
			else
			{
				this.SkedTree.Save(this._skedTreeFileName);
			}
		}

		public void SaveSkedTreeAs()
		{
			SaveFileDialog dialog	= new SaveFileDialog();
			dialog.Filter			= $"Skedula Files ({DEFAULT_EXTENSION})|{DEFAULT_EXTENSION}|All files (*.*)|(*.*)";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this._skedTreeFileName = dialog.FileName;
			}

			this.SkedTree.Save(this._skedTreeFileName);
		}
		#endregion

		#region SkedNode Management
		public void AddSkedNode()
		{
			if (this.SkedTree == null)
			{

				MessageBox.Show
								(
									"You must create a new sked tree or load one", 
									"No sked tree defined", 
									MessageBoxButtons.OKCancel, 
									MessageBoxIcon.Stop
								);

				return;
			}

			SkedNodeDialog dialog = new SkedNodeDialog();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				SkedNode skedNode = dialog.SkedNode;

				if (this.SelectedSkedNode != null)
				{
					this.SelectedSkedNode.Children.Add(skedNode);
					skedNode.ParentId	= this.SelectedSkedNode.Id;
				}
				else
				{
					this.SkedTree.Nodes.Add(skedNode);
					skedNode.ParentId = null;
				}
			}
			
			this.SkedTreeChanged?.Invoke(this.SkedTree);

			this.SaveSkedTree();
		}

		public void ReplaceSkedNode()
		{
			throw new NotImplementedException();
		}

		public void DeleteSkedNode()
		{
			throw new NotImplementedException();
		}
		#endregion

		#region Settings Management
		public void UpdateSettings()
		{
			throw new NotImplementedException();
		}

		public void LoadSettings()
		{
			throw new NotImplementedException();
		}

		public void SaveSettings()
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}
