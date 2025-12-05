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

			BSM.Instance.SkedTreeChanged += this.OnSkedTreeChanged;
			Factotum.Versioning.Version version = new Factotum.Versioning.Version();
			version.FromToml();

			this.Text = $"Skedula {version}";
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
	}
}
