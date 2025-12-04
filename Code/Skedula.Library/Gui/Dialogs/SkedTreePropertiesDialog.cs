/***********************************************************************************
* File:         SkedTreePropertiesDialog.cs                                        *
* Contents:     Class SkedTreePropertiesDialog                                     *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-12-04 17:56                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.ComponentModel;

namespace Skedula.Library.Gui.Dialogs
{
	public partial class SkedTreePropertiesDialog : Form
	{
		public SkedTreePropertiesDialog()
		{
			InitializeComponent();
			this._txName.Select();
		}

		private void OnOk(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OnCancel(object sender, EventArgs e)
		{

		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string ItemName
		{
			get
			{
				return this._txName.Text;
			}

			set
			{
				this._txName.Text = value;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string ItemDescription
		{
			get
			{
				return this._txDescription.Text;
			}

			set
			{
				this._txDescription.Text = value;
			}
		}
	}
}
