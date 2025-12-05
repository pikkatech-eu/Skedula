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
using BSM = Skedula.Library.Management.BasicSkedulaManager;

namespace Skedula.Library.Gui.Controls
{
	public partial class SkedTreeControl : UserControl, ISkedTreeDevice
	{
		public SkedTreeControl()
		{
			InitializeComponent();

			foreach (string key in BSM.Instance.Icons.Keys)
			{
				this._ilIcons.Images.Add(key, BSM.Instance.Icons[key]);
			}
		}

		public void Display(SkedTree skedTree)
		{
			this._tvSkedTree.Nodes.Clear();

			foreach (SkedNode skedNode in skedTree.Nodes)
			{
				TreeNode node	= new TreeNode(skedNode.Title);
				node.Tag		= skedNode;

				if (!String.IsNullOrEmpty(skedNode.IconKey))
				{
					node.ImageKey	= $"{BSM.ICON_FOLDER}{skedNode.IconKey}";
				}
				else
				{
					node.ImageKey	= "framework";
				}

				this._tvSkedTree.Nodes.Add(node);

				AppendChildNodes(skedNode, node);
			}
		}

		private void AppendChildNodes(SkedNode skedNode, TreeNode node)
		{
			foreach (SkedNode child in skedNode.Children)
			{
				TreeNode childTreeNode = new TreeNode(child.Title);
				childTreeNode.Tag = child;

				if (!String.IsNullOrEmpty(child.IconKey))
				{
					childTreeNode.ImageKey	= $"{BSM.ICON_FOLDER}{skedNode.IconKey}";
				}
				else
				{
					childTreeNode.ImageKey	= "framework";
				}

				node.Nodes.Add(childTreeNode);

				AppendChildNodes(child, childTreeNode);
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
		}

		private void OnNodeAdd(object sender, EventArgs e)
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
		}
	}
}
