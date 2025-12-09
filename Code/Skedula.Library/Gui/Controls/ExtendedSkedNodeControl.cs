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
using BSM = Skedula.Library.Management.BasicSkedulaManager;

namespace Skedula.Library.Gui.Controls
{
	public partial class ExtendedSkedNodeControl : UserControl, ISkedNodeDevice
	{
		public ExtendedSkedNodeControl()
		{
			InitializeComponent();

			foreach (string key in BSM.Instance.Icons.Keys)
			{
				this._ilIcons.Images.Add(key, BSM.Instance.Icons[key]);
			}

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
				this._txTitle.Text				= value.Title; 
				this._rxDescription.Text		= value.Description;
				this._cxPriority.SelectedItem	= value.Priority;
				this._cxStatus.SelectedItem		= value.Status;

				this._lblGuid.Text				= $"Guid: {value.Id}";
				this._lblDates.Text				= $"Created: {value.CreationTime:yyyy-MM-dd HH:mm} *** Last modified: {value.LastModified:yyyy-MM-dd HH:mm}";
				this._pbIcon.Image				= this._ilIcons.Images[BSM.ICON_FOLDER + value.IconKey];
			}
		}
	}
}
