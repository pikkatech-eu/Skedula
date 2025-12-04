/***********************************************************************************
* File:         SkedNodeControl.cs                                                 *
* Contents:     Class SkedNodeControl                                              *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-12-04 19:54                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.ComponentModel;
using Skedula.Library.Domain;
using Skedula.Library.Domain.Enumerations;
using Skedula.Library.Gui.Interfaces;

namespace Skedula.Library.Gui.Controls
{
	public partial class SkedNodeControl : UserControl, ISkedNodeDevice
	{
		public SkedNodeControl()
		{
			InitializeComponent();

			this._cxPriority.DataSource		= Enum.GetValues<Priority>();
			this._cxStatus.DataSource		= Enum.GetValues<Status>();

			this._cxPriority.SelectedItem	= Priority.Normal;
			this._cxStatus.SelectedItem		= Status.Pending;
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public SkedNode SkedNode
		{
			get
			{
				SkedNode sked		= new SkedNode();

				sked.Title			= this._txTitle.Text;
				sked.Description	= this._rxDescription.Text;

				sked.Priority		= (Priority)this._cxPriority.SelectedItem;
				sked.Status			= (Status)this._cxStatus.SelectedItem;

				return sked;
			}

			set
			{
				throw new NotImplementedException();
			}
		}
	}
}
