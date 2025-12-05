/***********************************************************************************
* File:         ISkedulaManager.cs                                                 *
* Contents:     Interface ISkedulaManager                                          *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-12-04 14:35                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Skedula.Library.Domain;

namespace Skedula.Library.Management
{
	public interface ISkedulaManager
	{
		#region Properties
		SkedTree	SkedTree				{get;set;}
		SkedNode	SelectedSkedNode		{get;set;}
		Settings	Settings				{get;set;}

		Dictionary<string, Image>	Icons	{get;}
		#endregion

		#region SkedTree Management
		void NewSkedTree();
		void EditSkedTree();
		void LoadSkedTree(string fileName = null);
		void SaveSkedTree();
		void SaveSkedTreeAs();
		#endregion

		#region SkedNode Management
		void AddSkedNode();
		void ReplaceSkedNode();
		void DeleteSkedNode();
		#endregion

		#region Settings Management
		void UpdateSettings();
		void LoadSettings();
		void SaveSettings();
		#endregion

		#region Events
		event Action<SkedTree> SkedTreeChanged;
		#endregion
	}
}
