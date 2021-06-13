using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Google.Apis.Download;
using System.Diagnostics;

namespace Google_Drive
{
	public partial class Form : System.Windows.Forms.Form
	{

		// If modifying these scopes, delete your previously saved credentials
		// at ~/.credentials/drive-dotnet-quickstart.json
		static string[] Scopes = { DriveService.Scope.Drive };
		static string AppName = "Drive API .NET Quickstart";
		private DriveService Service = new DriveService();

		// Function
		private List<string> listFilePathUpload = new List<string>();

		public Form()
		{
			InitializeComponent();
		}


		private void Form_Load(object sender, EventArgs e)
		{
			progressBar.Minimum = 0;
			progressBar.Value = 0;
		}

	}
}
