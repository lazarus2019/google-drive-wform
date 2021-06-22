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
using Google_Drive.Helpers;

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

		#region Get and create folder
		
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

		#region Upload files

		private void btnUpload_Click(object sender, EventArgs e)
		{
			if (Service.ApplicationName != AppName)
			{
				CreateService();
			}
			int fileUploadC = 0;
			if (this.listFilePathUpload.Count() > 0)
			{
				var helperExtension = new MimeTypeLookup();
				lbUpload.Text = $"{fileUploadC}/{this.listFilePathUpload.Count()} Uploading...";
				this.Cursor = Cursors.WaitCursor;
				foreach (var path in this.listFilePathUpload)
				{
					String filePath = path;
					if (!String.IsNullOrEmpty(filePath))
					{
						var vfile = new File();
						vfile.Name = filePath.Split('\\').Last();

						//var extension = GetExtensionFile(filePath);
						var extension = helperExtension.GetMimeType(vfile.Name);

						//var byteArr = System.IO.File.ReadAllBytes(filePath);
						var stream = new System.IO.FileStream(filePath, System.IO.FileMode.Open);
						FilesResource.CreateMediaUpload UploadReq = Service.Files.Create(vfile, stream, extension);
						UploadReq.Upload();
						try
						{
							var file = UploadReq.ResponseBody;
							Debug.WriteLine($"{file.Name} | {file.Id} | {file.CreatedTime}");
						}
						catch
						{
							MessageBox.Show("Can not upload file to google drive!", "Upload error", MessageBoxButtons.OK);
							this.Cursor = Cursors.Default;
						}
						fileUploadC++;
						lbUpload.Text = $"{fileUploadC}/{this.listFilePathUpload.Count()} Uploading...";
						progressBar.Value++;
						if (fileUploadC == this.listFilePathUpload.Count())
						{
							MessageBox.Show("Upload Successed");
							ResetUploadFunc();
							this.Cursor = Cursors.Default;
						}
					}
					else
					{
						MessageBox.Show("One of your file doesn't exist or direction go wrong!", "Upload error", MessageBoxButtons.OK);
						this.Cursor = Cursors.Default;
					}
				}
			}
			else
			{
				MessageBox.Show("You have to upload at least one file!", "Upload error", MessageBoxButtons.OK);
			}
		}

		public void ResetUploadFunc()
		{
			this.listFilePathUpload = new List<string>();
			progressBar.Value = 0;
		}

		private void btnBrowser_Click(object sender, EventArgs e)
		{
			var fileDialog = new OpenFileDialog();
			fileDialog.InitialDirectory = "C:\\Users\\mmofo\\OneDrive - ASHA DEVI POLYTECHNIC COLLEGE\\Desktop";
			fileDialog.Multiselect = true;
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				var filePaths = fileDialog.FileNames;
				foreach (var path in filePaths)
				{
					this.listFilePathUpload.Add(path);
				}
				progressBar.Maximum = this.listFilePathUpload.Count();
				progressBar.Step = 1;
			}
		}

		public string GetExtensionFile(String fileFullName)
		{
			var extension = fileFullName.Split('.').Last().ToLower();
			// Audio, Compressed, Disc and media, Data and database, E-mail, Executable, Font, Image, Internet-related, Presentation, Programming, Spreadsheet, System, Video, Word processor and text.
			String[] videoType = { "3gp", "avi", "flv", "h264", "m4v", "mkv", "mov", "mp4", "mpg", "mpeg", "rm", "swf", "vob", "wmv" };
			String[] wordType = { "doc", "docx", "odt", "wpd" };
			String[] textType = { "txt", "tex", "rtf" };
			String[] pdfType = { "pdf" };
			String[] audioType = { "mp3", "mpa", "ogg", "wav", "wma", "wpl" };
			String[] applicationType = { };
			String[] imageType = { "png", "jpeg", "jpg", "gif", "bmp", "svg", "tif", "tiff" };
			String[] spreadsheetType = { "xls", "xlsm", "xlsx" };
			String[] programType = { "c", "cgi", "pl", "class", "cpp", "cs", "h", "java", "php", "py", "sh", "swift", "vb" };
			String[] compressType = { "7z", "arj", "pkg", "rar", "rpm", "tar.gz", "z", "zip" };


			if (videoType.Contains(extension))
			{
				return "video/*";
			}
			else if (textType.Contains(extension) || programType.Contains(extension))
			{
				return "text/plain";
			}
			else if (audioType.Contains(extension))
			{
				return "audio/*";
			}
			else if (imageType.Contains(extension))
			{
				return "image/*";
			}
			else if (pdfType.Contains(extension))
			{
				return "application/pdf";
			}

			return "application/*";
		}

		#endregion
	}
}
