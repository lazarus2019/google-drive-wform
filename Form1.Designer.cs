
namespace Google_Drive
{
	partial class Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.inputRequest = new System.Windows.Forms.TextBox();
			this.inputFolderId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.inputCreateDeleteFolder = new System.Windows.Forms.TextBox();
			this.btnCreateFolder = new System.Windows.Forms.Button();
			this.btnCreateSFolder = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.cBoxDelete = new System.Windows.Forms.CheckBox();
			this.btnRequest = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.btnUpload = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.button8 = new System.Windows.Forms.Button();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.lbUpload = new System.Windows.Forms.Label();
			this.btnBrowser = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// inputRequest
			// 
			this.inputRequest.Location = new System.Drawing.Point(12, 12);
			this.inputRequest.Name = "inputRequest";
			this.inputRequest.Size = new System.Drawing.Size(437, 20);
			this.inputRequest.TabIndex = 0;
			// 
			// inputFolderId
			// 
			this.inputFolderId.Location = new System.Drawing.Point(12, 75);
			this.inputFolderId.Name = "inputFolderId";
			this.inputFolderId.Size = new System.Drawing.Size(352, 20);
			this.inputFolderId.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(367, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "DownloadFileID";
			// 
			// inputCreateDeleteFolder
			// 
			this.inputCreateDeleteFolder.Location = new System.Drawing.Point(12, 112);
			this.inputCreateDeleteFolder.Name = "inputCreateDeleteFolder";
			this.inputCreateDeleteFolder.Size = new System.Drawing.Size(352, 20);
			this.inputCreateDeleteFolder.TabIndex = 4;
			// 
			// btnCreateFolder
			// 
			this.btnCreateFolder.Location = new System.Drawing.Point(12, 154);
			this.btnCreateFolder.Name = "btnCreateFolder";
			this.btnCreateFolder.Size = new System.Drawing.Size(119, 23);
			this.btnCreateFolder.TabIndex = 5;
			this.btnCreateFolder.Text = "Create Folder";
			this.btnCreateFolder.UseVisualStyleBackColor = true;
			this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
			// 
			// btnCreateSFolder
			// 
			this.btnCreateSFolder.Location = new System.Drawing.Point(150, 154);
			this.btnCreateSFolder.Name = "btnCreateSFolder";
			this.btnCreateSFolder.Size = new System.Drawing.Size(119, 23);
			this.btnCreateSFolder.TabIndex = 6;
			this.btnCreateSFolder.Text = "Create Sub Folder";
			this.btnCreateSFolder.UseVisualStyleBackColor = true;
			this.btnCreateSFolder.Click += new System.EventHandler(this.btnCreateSFolder_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(287, 154);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Detele";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// cBoxDelete
			// 
			this.cBoxDelete.AutoSize = true;
			this.cBoxDelete.Location = new System.Drawing.Point(370, 116);
			this.cBoxDelete.Name = "cBoxDelete";
			this.cBoxDelete.Size = new System.Drawing.Size(57, 17);
			this.cBoxDelete.TabIndex = 8;
			this.cBoxDelete.Text = "Delete";
			this.cBoxDelete.UseVisualStyleBackColor = true;
			// 
			// btnRequest
			// 
			this.btnRequest.Location = new System.Drawing.Point(374, 40);
			this.btnRequest.Name = "btnRequest";
			this.btnRequest.Size = new System.Drawing.Size(75, 23);
			this.btnRequest.TabIndex = 1;
			this.btnRequest.Text = "Request";
			this.btnRequest.UseVisualStyleBackColor = true;
			this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(356, 236);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Download File";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(12, 208);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(350, 20);
			this.textBox4.TabIndex = 9;
			// 
			// btnUpload
			// 
			this.btnUpload.Location = new System.Drawing.Point(12, 236);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(93, 23);
			this.btnUpload.TabIndex = 10;
			this.btnUpload.Text = "Upload File";
			this.btnUpload.UseVisualStyleBackColor = true;
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(381, 192);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "DownloadTo";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(12, 278);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(437, 20);
			this.textBox5.TabIndex = 12;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(12, 306);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(93, 23);
			this.button8.TabIndex = 13;
			this.button8.Text = "Download File";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(12, 353);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(437, 23);
			this.progressBar.TabIndex = 14;
			// 
			// lbUpload
			// 
			this.lbUpload.AutoSize = true;
			this.lbUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUpload.ForeColor = System.Drawing.Color.Green;
			this.lbUpload.Location = new System.Drawing.Point(199, 382);
			this.lbUpload.Name = "lbUpload";
			this.lbUpload.Size = new System.Drawing.Size(80, 16);
			this.lbUpload.TabIndex = 15;
			this.lbUpload.Text = "Uploading...";
			// 
			// btnBrowser
			// 
			this.btnBrowser.Location = new System.Drawing.Point(374, 206);
			this.btnBrowser.Name = "btnBrowser";
			this.btnBrowser.Size = new System.Drawing.Size(75, 23);
			this.btnBrowser.TabIndex = 16;
			this.btnBrowser.Text = "Browser";
			this.btnBrowser.UseVisualStyleBackColor = true;
			this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 407);
			this.Controls.Add(this.btnBrowser);
			this.Controls.Add(this.lbUpload);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnUpload);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.cBoxDelete);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCreateSFolder);
			this.Controls.Add(this.btnCreateFolder);
			this.Controls.Add(this.inputCreateDeleteFolder);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.inputFolderId);
			this.Controls.Add(this.btnRequest);
			this.Controls.Add(this.inputRequest);
			this.Name = "Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Google Drive API";
			this.Load += new System.EventHandler(this.Form_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inputRequest;
		private System.Windows.Forms.TextBox inputFolderId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox inputCreateDeleteFolder;
		private System.Windows.Forms.Button btnCreateFolder;
		private System.Windows.Forms.Button btnCreateSFolder;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.CheckBox cBoxDelete;
		private System.Windows.Forms.Button btnRequest;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Label lbUpload;
		private System.Windows.Forms.Button btnBrowser;
	}
}

