/***********************************************************************************
* File:         SkedTreeControl.cs                                                 *
* Contents:     Class SkedTreeControl                                              *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-12-05 09:42                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Skedula.Library.Domain;
using Skedula.Library.Gui.Interfaces;
using Skedula.Library.Management;
using BSM = Skedula.Library.Management.BasicSkedulaManager;

namespace Skedula.Library.Gui.Controls
{
	public partial class SkedTreeControl : UserControl, ISkedTreeDevice
	{
		internal const string DEFAULT_LEAF_ICON = "leaf_16";
		internal const string DEFAULT_TREE_ICON = "tree_16";

		public SkedTreeControl()
		{
			InitializeComponent();

			foreach (string key in BSM.Instance.Icons.Keys)
			{
				this._ilIcons.Images.Add(key, BSM.Instance.Icons[key]);
			}
		}

		public event Action<SkedNode> SkedSelected;

		public void Display(SkedTree skedTree)
		{
			this._tvSkedTree.Nodes.Clear();

			foreach (SkedNode skedNode in skedTree.Nodes)
			{
				TreeNode node = new TreeNode(skedNode.Title);
				node.Tag = skedNode;
				string imageKey = "";

				if (!String.IsNullOrEmpty(skedNode.IconKey))
				{
					imageKey = $"{BSM.ICON_FOLDER}{skedNode.IconKey}";
					node.ImageKey = imageKey;
					node.SelectedImageKey = imageKey;
				}
				else
				{
					imageKey = skedNode.IsLeaf() ? DEFAULT_LEAF_ICON : DEFAULT_TREE_ICON;
					node.ImageKey = imageKey;
					node.SelectedImageKey = imageKey;
				}

				this._tvSkedTree.Nodes.Add(node);

				AppendChildNodes(skedNode, node);
			}

			this._tvSkedTree.ExpandAll();
		}

		private void AppendChildNodes(SkedNode skedNode, TreeNode node)
		{
			foreach (SkedNode childSkedNode in skedNode.Children)
			{
				TreeNode childTreeNode = new TreeNode(childSkedNode.Title);
				childTreeNode.Tag = childSkedNode;
				string imageKey = "";

				if (!String.IsNullOrEmpty(childSkedNode.IconKey))
				{
					imageKey = $"{skedNode.IconKey}";
					childTreeNode.ImageKey = imageKey;
					childTreeNode.SelectedImageKey = imageKey;
				}
				else
				{
					imageKey = childSkedNode.IsLeaf() ? DEFAULT_LEAF_ICON : DEFAULT_TREE_ICON;
					childTreeNode.ImageKey = imageKey;
					childTreeNode.SelectedImageKey = imageKey;
				}

				node.Nodes.Add(childTreeNode);

				AppendChildNodes(childSkedNode, childTreeNode);
			}
		}

		private void SelectedNodeChanged(object sender, TreeViewEventArgs e)
		{
			if (e.Node != null)
			{
				BSM.Instance.SelectedSkedNode = e.Node.Tag as SkedNode;
			}
			else
			{
				BSM.Instance.SelectedSkedNode = null;
			}

			this.SkedSelected?.Invoke(BSM.Instance.SelectedSkedNode);
		}

		private void OnNodeAddRootNode(object sender, EventArgs e)
		{
			BSM.Instance.AddSkedNode(true);
		}

		private void OnNodeAddSubnode(object sender, EventArgs e)
		{
			BSM.Instance.AddSkedNode();
		}

		private void OnNodeEdit(object sender, EventArgs e)
		{
			BSM.Instance.ReplaceSkedNode();
		}

		private void OnNodeDelete(object sender, EventArgs e)
		{
			BSM.Instance.DeleteSkedNode();
		}

		private void OnUnselect(object sender, EventArgs e)
		{
			this._tvSkedTree.SelectedNode = null;

			this._tvSkedTree.HideSelection = false;
			this._tvSkedTree.Refresh();
			this._tvSkedTree.Focus();

			BasicSkedulaManager.Instance.SelectedSkedNode = null;
		}


	}
}
