/***********************************************************************************
* File:         SkedNode.cs                                                        *
* Contents:     Class SkedNode                                                     *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-12-04 14:22                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Skedula.Library.Domain.Enumerations;

namespace Skedula.Library.Domain
{
	/// <summary>
	/// Defines a node of the task tree. The word "sked" is used here as a synonym for Task, 
	/// to tell it from C#'s class task.
	/// </summary>
	public class SkedNode
	{
		#region Properties
		public Guid				Id				{get;set;} = Guid.NewGuid();
		public string			Title			{get;set;} = string.Empty;
		public string			Description		{get;set;} = string.Empty;
		public DateTime			CreationTime	{get;set;} = DateTime.Now;
		public DateTime			LastModified	{get;set;} = DateTime.Now;
		public Priority			Priority		{get;set;} = Priority.Normal;
		public string			IconKey			{get;set;}
		public Guid?			ParentId		{get;set;}
		public List<SkedNode>	Children		{get;set;} = new();
		public Status			Status			{get;set;} = Status.Pending;
		#endregion
	}
}
