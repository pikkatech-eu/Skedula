/***********************************************************************************
* File:         ISkedTreeDevice.cs                                                 *
* Contents:     Interface ISkedTreeDevice                                          *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-12-05 09:37                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Skedula.Library.Domain;

namespace Skedula.Library.Gui.Interfaces
{
	public interface ISkedTreeDevice
	{
		void Display(SkedTree skedTree);
	}
}
