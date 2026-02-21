/***********************************************************************************
* File:         HtmlCreator.cs                                                     *
* Contents:     Class HtmlCreator                                                  *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-02-21 21:23                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Factotum.Xml;
using Skedula.Library.Domain;

namespace Skedula.Library.Tools
{
	/// <summary>
	/// Converts XML output of SkedTree to HTML.
	/// </summary>
	public static class HtmlCreator
	{
		private static readonly string HEADER = @"
<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
</head>
<body>";

		private static readonly string FOOTER = @"
</body>
</html>
";
		public static string ToHtml(SkedTree tree)
		{
			string title = tree.Title;
			string description = tree.Description;

			string html = HEADER.Replace("Document", title);
			html += $"\n<h1>{title}</h1>";
			html += $"\n<h2>{description}</h2>";

			foreach (SkedNode node in tree.Nodes)
			{
				string htmlNode = NodeToHtml(node);

				html += $"\n{htmlNode}";
			}

			html += FOOTER;

			return html;
		}

		private static string NodeToHtml(SkedNode node)
		{
			string html = $"\n<h3>{node.Title}</h3>";
			html += $"\n<h4>{node.Description}</h4>";
			html += $"\n<h4>Status: {node.Status}</h4>";
			html += $"\n<h4>Priority: {node.Priority}</h4>";

			foreach (SkedNode child in node.Children)
			{
				html += NodeToHtml(child);
			}

			return html;
		}
	}
}
