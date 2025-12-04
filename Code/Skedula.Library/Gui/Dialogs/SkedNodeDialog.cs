/***********************************************************************************
* File:         SkedNodeDialog.cs                                                  *
* Contents:     Class SkedNodeDialog                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-11-06 15:55                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Skedula.Library.Domain;
using Skedula.Library.Gui.Interfaces;
using System.ComponentModel;

namespace Skedula.Library.Gui.Dialogs
{
	public partial class SkedNodeDialog : Form, ISkedNodeDevice
	{
		public SkedNodeDialog()
		{
			InitializeComponent();
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public SkedNode SkedNode
		{
			get
			{
				return this._ctrlSkedNode.SkedNode;
			}

			set
			{
				this._ctrlSkedNode.SkedNode = value;
			}
		}
	}
}
