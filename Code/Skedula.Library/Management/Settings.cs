/***********************************************************************************
* File:         Settings.cs                                                        *
* Contents:     Class Settings                                                     *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-11 14:06                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.ComponentModel;
using System.Text.Json;

namespace Skedula.Library.Management
{
	public class Settings
	{
		#region Constants
		internal static readonly string DEFAULT_SETTINGS_FILE_NAME = "settings.json";
		internal static readonly int NUMBER_OF_ROP = 20;
		#endregion

		#region Properties
		[Category("General")]
		[Description("If set to true, will try to open the last project.")]
		public bool AutoLoadLastProject	{get;set;}	= false;

		[Browsable(false)]
		public List<string>	RecentlyOpenedProjects	{get;set;}	= new List<string>();
		#endregion

		#region Recent project management
		public void AddRecentlyOpenedProject(string fileName)
		{
			if (!this.RecentlyOpenedProjects.Contains(fileName))
			{
				this.RecentlyOpenedProjects.Insert(0, fileName);

				if (this.RecentlyOpenedProjects.Count > NUMBER_OF_ROP)
				{
					this.RecentlyOpenedProjects.RemoveAt(NUMBER_OF_ROP);
				}

				this.RecentlyOpenedProjectsChanged?.Invoke(this.RecentlyOpenedProjects);
			}
		}

		public void RemoveRecentlyOpenedProject(string fileName)
		{
			if (this.RecentlyOpenedProjects.Contains(fileName))
			{
				this.RecentlyOpenedProjects.Remove(fileName);
				this.RecentlyOpenedProjectsChanged?.Invoke(this.RecentlyOpenedProjects);
			}
		}
		#endregion

		#region Serialization
		public string ToJson()
		{
			var options = new JsonSerializerOptions {WriteIndented = true};
			return JsonSerializer.Serialize<Settings>(this, options);
		}

		public static Settings FromJson(string json)
		{
			return JsonSerializer.Deserialize<Settings>(json);
		}

		/// <summary>
		/// Saves the settings to a file.
		/// </summary>
		/// <param name="fileName">The name of the file to save under.</param>
		public void Save(string fileName)
		{
			using (StreamWriter writer = new StreamWriter(fileName))
			{
				string json	= this.ToJson();
				writer.Write(json);
			}
		}

		/// <summary>
		/// Loads settings feom a JSON file.
		/// </summary>
		/// <param name="fileName">The name of the file to create from.</param>
		/// <returns>An instance of Settings, if succesful.s</returns>
		public static Settings Load(string fileName)
		{
			using (StreamReader reader= new StreamReader(fileName))
			{
				string json	= reader.ReadToEnd();

				return FromJson(json);
			}
		}

		public void Save()
		{
			string exeFolder = Application.StartupPath;
			string settingsPath	= Path.Combine(exeFolder, DEFAULT_SETTINGS_FILE_NAME);
			this.Save(settingsPath);
		}

		public static Settings Load()
		{
			string exeFolder	= Application.StartupPath;
			string settingsPath	= Path.Combine(exeFolder, DEFAULT_SETTINGS_FILE_NAME);

			if (File.Exists(settingsPath))
			{
				return Load(settingsPath);
			}
			else
			{
				Settings settings = new Settings();
				settings.Save();

				return settings;
			}
		}
		#endregion

		#region RecentlyOpenedProjects Menu
		public event Action<List<string>> RecentlyOpenedProjectsChanged;
		#endregion
	}
}
