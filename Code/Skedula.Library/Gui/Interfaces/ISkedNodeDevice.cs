/***********************************************************************************
* File:         ISkedNodeDevice.cs                                                 *
* Contents:     Interface ISkedNodeDevice                                          *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-12-04 19:37                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Skedula.Library.Domain;

namespace Skedula.Library.Gui.Interfaces
{
	public interface ISkedNodeDevice
	{
		SkedNode SkedNode	{get;set;}
	}
}
