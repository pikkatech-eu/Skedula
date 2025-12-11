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
using static Skedula.Library.Gui.Controls.ImageComboBox;
using BSM = Skedula.Library.Management.BasicSkedulaManager;

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

			this._cxIcons.ImageDictionary	= BSM.Instance.Icons;

			foreach (string iconFile in BSM.Instance.Icons.Keys)
			{
				string iconName = new FileInfo(iconFile).Name;
				this._cxIcons.AddItem(iconName, iconFile);
			}
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

				sked.IconKey		= this._cxIcons.SelectedItem?.ToString();

				return sked;
			}

			set
			{
				this._txTitle.Text				= value.Title; 
				this._rxDescription.Text		= value.Description;
				this._cxPriority.SelectedItem	= value.Priority;
				this._cxStatus.SelectedItem		= value.Status;

				var existing					= _cxIcons.Items.OfType<ImageComboItem>().FirstOrDefault(x => x.ImageKey == value.IconKey);

				if (existing != null)
				{
					this._cxIcons.SelectedItem = existing;
				}
			}
		}
	}
}
