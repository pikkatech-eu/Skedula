/***********************************************************************************
* File:         BasicSkedulaManager.cs                                             *
* Contents:     Class BasicSkedulaManager                                          *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-12-04 14:36                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Skedula.Library.Domain;
using Skedula.Library.Gui.Dialogs;
using Skedula.Library.Tools;

[assembly:InternalsVisibleTo("Skedula")]

namespace Skedula.Library.Management
{
	public class BasicSkedulaManager : ISkedulaManager
	{
		#region Constants
		internal const string DEFAULT_EXTENSION = "*.sked";

		internal const string ICON_FOLDER		= ".\\icons\\";
		#endregion

		#region Singletonia
		private static readonly Lazy<BasicSkedulaManager> _instance = new Lazy<BasicSkedulaManager>(() => new BasicSkedulaManager());
		public static BasicSkedulaManager Instance => _instance.Value;
		private BasicSkedulaManager() 
		{
			this.Settings = Settings.Load();

			if (!Directory.Exists(ICON_FOLDER))
			{
				Directory.CreateDirectory(ICON_FOLDER);
			}

			this.LoadIcons();
		}
		#endregion

		#region Internal Members
		internal string SkedTreeFileName	{get;set;} = null;
		#endregion

		#region Properties
		public SkedTree						SkedTree			{get;set;}	= null;

		public SkedNode						SelectedSkedNode	{get;set;}	= null;

		public Settings						Settings			{get;set;}	= new Settings();

		public Dictionary<string, Image>	Icons				{get;internal set;}	= new();
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

				this.Settings.AddRecentlyOpenedProject(this.SkedTreeFileName);
				this.Settings.Save();
			}
		}

		public void LoadSkedTree(string fileName = null)
		{
			if (String.IsNullOrEmpty(fileName))
			{
				OpenFileDialog dialog	= new OpenFileDialog();
				dialog.Filter			= $"Skedula Files ({DEFAULT_EXTENSION})|{DEFAULT_EXTENSION}|All files (*.*)|(*.*)";

				if (dialog.ShowDialog() == DialogResult.OK)
				{
					this.SkedTreeFileName	= dialog.FileName;
				}
			}
			else
			{
				this.SkedTreeFileName	= fileName;
			}

			this.SkedTree			= SkedTree.Load(this.SkedTreeFileName);

			this.SkedTreeChanged(this.SkedTree);

			this.Settings.AddRecentlyOpenedProject(this.SkedTreeFileName);
			this.Settings.Save();
		}

		public void SaveSkedTree()
		{
			if (String.IsNullOrEmpty(this.SkedTreeFileName))
			{
				this.SaveSkedTreeAs();
			}
			else
			{
				if (File.Exists(this.SkedTreeFileName))
				{
					this.SkedTree.Save(this.SkedTreeFileName);
				}
				else
				{
					this.SaveSkedTreeAs();
				}
			}
		}

		public void SaveSkedTreeAs()
		{
			SaveFileDialog dialog	= new SaveFileDialog();
			dialog.Filter			= $"Skedula Files ({DEFAULT_EXTENSION})|{DEFAULT_EXTENSION}|All files (*.*)|(*.*)";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.SkedTreeFileName = dialog.FileName;
			}

			try
			{
				this.SkedTree.Save(this.SkedTreeFileName);
			}
			catch (Exception)	{}
		}

		public XElement ToXElement()
		{
			if (this.SkedTree == null)
			{
				return null;
			}
			else
			{
				return this.SkedTree.ToXElement();
			}
		}

		public string ToHtml()
		{
			if (this.SkedTree == null)
			{
				return null;
			}
			else
			{
				return HtmlCreator.ToHtml(this.SkedTree);
			}
		}

		public void EditSkedTree()
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

			SkedTreePropertiesDialog dialog = new SkedTreePropertiesDialog();
			dialog.ItemName					= this.SkedTree.Title;
			dialog.ItemDescription			= this.SkedTree.Description;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.SkedTree.Title			= dialog.ItemName;
				this.SkedTree.Description	= dialog.ItemDescription;
				this.SkedTree.LastModified	= DateTime.Now;

				this.SaveSkedTree();
			}
		}
		#endregion

		#region SkedNode Management
		/// <summary>
		/// Adds a sked node to either the tree itself ("root" node) or to the momentarily selected sked node.
		/// </summary>
		/// <param name="isRootNode">If true, a root node should be added.</param>
		public void AddSkedNode(bool isRootNode = false)
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

				if (!isRootNode && this.SelectedSkedNode != null)
				{
					this.SelectedSkedNode.Children.Add(skedNode);
					skedNode.ParentId	= this.SelectedSkedNode.Id;
				}
				else if (isRootNode)
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
			if (this.SelectedSkedNode == null)
			{
				return;
			}

			SkedNodeDialog dialog = new SkedNodeDialog();
			dialog.SkedNode = this.SelectedSkedNode;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.SkedTree.Replace(this.SelectedSkedNode.Id, dialog.SkedNode);

				this.SkedTreeChanged?.Invoke(this.SkedTree);

				this.SaveSkedTree();
			}
		}

		public void DeleteSkedNode()
		{
			if (this.SelectedSkedNode == null)
			{
				return;
			}


			if (
					MessageBox.Show
									(
										$"Sure to delete node {this.SelectedSkedNode}?", 
										"Node about to be deleted", 
										MessageBoxButtons.OKCancel, 
										MessageBoxIcon.Question
									) == DialogResult.OK
				)
			{
				this.SkedTree.Delete(this.SelectedSkedNode.Id);

				this.SkedTreeChanged?.Invoke(this.SkedTree);
				this.SaveSkedTree();
			}
				
		}

		/// <summary>
		/// Tries to insert a node as a sibling of the currently selected node, just under it.
		/// </summary>
		public void InsertNode()
		{
			//------------------------- DEBUG! ---------
			//Guid guidParent = Guid.Parse("5c9ff7fa-58bc-4b72-99cd-3d519ac59a3e");
			//Guid guid1 = Guid.Parse("b5ccd8bb-15e8-49f0-a318-988227652c22");
			//Guid guid2 = Guid.Parse("acccb24c-0353-4c23-85b2-e6d571b0be7a");

			//SkedNode node1 = this.FindNode(guid1);
			//SkedNode node2 = this.FindNode(guid2);

			//SkedNode parent0 = this.FindNode(guidParent);
			//parent0.SwapChildren(node1, node2);
			//------------------------------------------

			if (this.SelectedSkedNode != null)
			{
				if (this.SelectedSkedNode.ParentId != null)
				{
					SkedNode parent = this.FindNode((Guid)this.SelectedSkedNode.ParentId);

					int index = parent.Children.IndexOf(this.SelectedSkedNode);

					SkedNodeDialog dialog = new SkedNodeDialog();

					if (dialog.ShowDialog() == DialogResult.OK)
					{
						SkedNode skedNode = dialog.SkedNode;

						skedNode.ParentId = this.SelectedSkedNode.Id;

						parent.Children.Insert(index + 1, skedNode);

						this.SkedTreeChanged?.Invoke(this.SkedTree);
						this.SaveSkedTree();
					}
				}
				else
				{
					int index = this.SkedTree.Nodes.IndexOf(this.SelectedSkedNode);

					SkedNodeDialog dialog = new SkedNodeDialog();

					if (dialog.ShowDialog() == DialogResult.OK)
					{
						SkedNode skedNode = dialog.SkedNode;

						this.SkedTree.Nodes.Insert(index + 1, skedNode);

						this.SkedTreeChanged?.Invoke(this.SkedTree);
						this.SaveSkedTree();
					}
				}
			}
		}

		public SkedNode FindNode(Guid id)
		{
			if (this.SkedTree != null)
			{
				return this.SkedTree.Find(id);
			}
			else
			{
				return null;
			}
		}

		public void MoveUp()
		{
			if (this.SelectedSkedNode == null)
			{
				return;
			}

			if (SelectedSkedNode.ParentId != null)
			{
				SkedNode parent = this.FindNode((Guid)this.SelectedSkedNode.ParentId);

				int index = parent.Children.IndexOf(this.SelectedSkedNode);

				if (index > 0)
				{
					parent.SwapChildren(this.SelectedSkedNode, parent.Children[index - 1]);

					this.SkedTreeChanged?.Invoke(this.SkedTree);
					this.SaveSkedTree();
				}
			}
		}

		public void MoveDown()
		{
			if (this.SelectedSkedNode == null)
			{
				return;
			}

			if (SelectedSkedNode.ParentId != null)
			{
				SkedNode parent = this.FindNode((Guid)this.SelectedSkedNode.ParentId);
				int index = parent.Children.IndexOf(this.SelectedSkedNode);

				if (index < parent.Children.Count - 1)
				{
					parent.SwapChildren(parent.Children[index + 1], this.SelectedSkedNode);

					this.SkedTreeChanged?.Invoke(this.SkedTree);
					this.SaveSkedTree();
				}
			}
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

		#region Private Auxiliary
		private void LoadIcons()
		{
			string[] fileNames = Directory.GetFiles(ICON_FOLDER);

			this.Icons.Clear();

			foreach (string fileName in fileNames)
			{
				try
				{
					Image icon		= Image.FromFile(fileName);
					string imageKey	= Path.GetFileName(fileName);
					this.Icons.Add(imageKey, icon);
				}
				catch (Exception)	{}
			}
		}
		#endregion
	}
}
