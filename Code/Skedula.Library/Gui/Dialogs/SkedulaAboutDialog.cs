/***********************************************************************************
* File:         KairosAboutDialog.cs                                                  *
* Contents:     Class KairosAboutDialog                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-11-06 15:55                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Diagnostics;
using FV = Factotum.Versioning;

namespace Kairos.Library.Gui
{
	public partial class SkedulaAboutDialog : Form
	{
		private const string COMPANY_URL = "http://www.pikkatech.eu";
		private const string PROJECT_URL = "https://github.com/pikkatech-eu/Skedula/";

		public SkedulaAboutDialog()
		{
			InitializeComponent();

			FV.Version version = new FV.Version();
			version.FromToml();

			this._txVersion.Text = $"Skedula {version}";
		}

		private void OnPikkatechLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				ProcessStartInfo sInfo = new ProcessStartInfo(COMPANY_URL);
				sInfo.UseShellExecute = true;
				Process.Start(sInfo);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void OnProjectLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				ProcessStartInfo sInfo = new ProcessStartInfo(PROJECT_URL);
				sInfo.UseShellExecute = true;
				Process.Start(sInfo);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
