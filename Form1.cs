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
		#region Declare valriables
		// If modifying these scopes, delete your previously saved credentials
		// at ~/.credentials/drive-dotnet-quickstart.json
		static string[] Scopes = { DriveService.Scope.Drive };
		static string AppName = "Drive API .NET Quickstart";
		private DriveService Service = new DriveService();

		// Function
		private List<string> listFilePathUpload = new List<string>();

		#endregion

		#region Default form
		public Form()
		{
			InitializeComponent();
		}

		private void Form_Load(object sender, EventArgs e)
		{
			progressBar.Minimum = 0;
			progressBar.Value = 0;
		}

		#endregion

		#region Create token and basic request

		public void CreateService()
		{
			UserCredential cre;
			var credPath = "token.json";

			using (var stream = new System.IO.FileStream("ggdrive_client_secret.json", System.IO.FileMode.Open, System.IO.FileAccess.Read))
			{
				cre = GoogleWebAuthorizationBroker.AuthorizeAsync(
					GoogleClientSecrets.Load(stream).Secrets,
					Scopes,
					"user",
					CancellationToken.None,
					new FileDataStore(credPath, true)).Result;
				Console.WriteLine("Credential file saved to: " + credPath);

				// Create Drive API service.
				Service = new DriveService(new BaseClientService.Initializer()
				{
					HttpClientInitializer = cre,
					ApplicationName = AppName,
				});
			}
		}

		private void btnRequest_Click(object sender, EventArgs e)
		{
			if (Service.ApplicationName != AppName)
			{
				CreateService();
			}
			ListFilesandFodlers();
		}

		#endregion

		#region Folder
		
		public void ListFilesandFodlers()
		{
			if (Service.ApplicationName != AppName)
			{
				CreateService();
			}

			var downloader = new MediaDownloader(Service);

			var request = Service.Files.List();

			request.Q = inputRequest.Text;

			var results = request.Execute();

			foreach (var result in results.Files)
			{
				Debug.WriteLine($"{result.Name} | {result.Id}");
			}
		}

		private void btnCreateFolder_Click(object sender, EventArgs e)
		{
			if (Service.ApplicationName != AppName)
			{
				CreateService();
			}
			var vfolder = new File();
			vfolder.Name = inputCreateDeleteFolder.Text;
			vfolder.MimeType = "application/vnd.google-apps.folder";

			var reqSetup = Service.Files.Create(vfolder);
			reqSetup.Fields = "id";

			var reqExe = reqSetup.Execute();
			Debug.WriteLine(reqExe.Id);
			MessageBox.Show("Create folder successed");
		}

		public void CreateNewSubFolder(String subFolderName, String parentFolderId)
		{
			if (Service.ApplicationName != AppName)
			{
				CreateService();
			}
			var vfolder = new File();
			vfolder.Name = subFolderName;
			vfolder.MimeType = "application/vnd.google-apps.folder";
			vfolder.Parents = new List<string> { parentFolderId };

			var reqSetup = Service.Files.Create(vfolder);
			reqSetup.Fields = "id";

			var reqExe = reqSetup.Execute();
			Debug.WriteLine(reqExe.Id);
			MessageBox.Show("Create folder successed!");
		}

		private void btnCreateSFolder_Click(object sender, EventArgs e)
		{
			CreateNewSubFolder(inputCreateDeleteFolder.Text, inputFolderId.Text);
		}


		#endregion


	}
}
