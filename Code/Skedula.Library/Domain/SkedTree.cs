/***********************************************************************************
* File:         SkedTree.cs                                                        *
* Contents:     Class SkedTree                                                     *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-12-04 14:30                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using Skedula.Library.Management;

namespace Skedula.Library.Domain
{
	public class SkedTree
	{
		#region Properties
		public List<SkedNode>	Nodes			{get;set;}	= new();
		public string			Title			{get;set;}	= string.Empty;
		public string			Description		{get;set;}	= string.Empty;
		public DateTime			CreationTime	{get;set;}	= DateTime.Now;
		public DateTime			LastModified	{get;set;}	= DateTime.Now;
		#endregion

		#region Management
		public SkedNode Find(Guid nodeId)
		{
			foreach (SkedNode skedNode in this.Nodes)
			{
				SkedNode found = Find(nodeId, skedNode);

				if (found != null)
				{
					return found;
				}
			}

			return null;
		}

		public void Replace(Guid guid, SkedNode skedNode)
		{
			SkedNode found = this.Find(guid);

			if (found == null)
			{
				return;
			}

			found.Title			= skedNode.Title;
			found.Description	= skedNode.Description;
			found.Priority		= skedNode.Priority;
			found.Status		= skedNode.Status;
			found.IconKey		= skedNode.IconKey;
			found.LastModified	= DateTime.Now;
		}
		#endregion

		#region Serialization
		public string ToJson()
		{
			JsonSerializerOptions options = new JsonSerializerOptions
																	{
																		WriteIndented=true, 
																		Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
																	};

			string json = JsonSerializer.Serialize(this, options);

			return json;
		}

		public static SkedTree FromJson(string json)
		{
			SkedTree skedTree	= JsonSerializer.Deserialize<SkedTree>(json);
			return skedTree;
		}

		public void Save(string fileName)
		{
			using (StreamWriter writer = new StreamWriter(fileName))
			{
				writer.Write(this.ToJson());
			}
		}

		public static SkedTree Load(string fileName)
		{
			using (StreamReader reader = new StreamReader(fileName))
			{
				string json = reader.ReadToEnd();

				return FromJson(json);
			}
		}
		#endregion

		private SkedNode Find(Guid nodeId, SkedNode skedNode)
		{
			if (skedNode.Id == nodeId)
			{
				return skedNode;
			}

			foreach (SkedNode child in skedNode.Children)
			{
				SkedNode found = Find(nodeId, child);

				if (found != null)
				{
					return found;
				}
			}

			return null;
		}

		internal void Delete(Guid id)
		{
			SkedNode found = this.Find(id);

			if (found == null)
			{
				return;
			}

			if (found.ParentId == null)
			{
				// found is a root node
				this.Nodes.Remove(found);
			}
			else
			{
				SkedNode parent = this.Find((Guid)found.ParentId);
				parent.Children.Remove(found);
			}
		}
	}
}
