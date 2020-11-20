namespace YoutubeConverter
{
    partial class VideoConverter
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
			this.components = new System.ComponentModel.Container();
			this.txbURL = new System.Windows.Forms.TextBox();
			this.btnDownload = new System.Windows.Forms.Button();
			this.btnDownloadAudio = new System.Windows.Forms.Button();
			this.openFileVideo = new System.Windows.Forms.OpenFileDialog();
			this.btnBrowser = new System.Windows.Forms.Button();
			this.btnConvert = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.process1 = new System.Diagnostics.Process();
			this.lbLoading = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txbURL
			// 
			this.txbURL.Location = new System.Drawing.Point(65, 80);
			this.txbURL.Name = "txbURL";
			this.txbURL.Size = new System.Drawing.Size(509, 20);
			this.txbURL.TabIndex = 0;
			// 
			// btnDownload
			// 
			this.btnDownload.Location = new System.Drawing.Point(65, 121);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(108, 31);
			this.btnDownload.TabIndex = 1;
			this.btnDownload.Text = "Download video";
			this.btnDownload.UseVisualStyleBackColor = true;
			this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
			// 
			// btnDownloadAudio
			// 
			this.btnDownloadAudio.Location = new System.Drawing.Point(448, 121);
			this.btnDownloadAudio.Name = "btnDownloadAudio";
			this.btnDownloadAudio.Size = new System.Drawing.Size(126, 31);
			this.btnDownloadAudio.TabIndex = 2;
			this.btnDownloadAudio.Text = "Download audio";
			this.btnDownloadAudio.UseVisualStyleBackColor = true;
			this.btnDownloadAudio.Click += new System.EventHandler(this.btnDownloadAudio_Click);
			// 
			// openFileVideo
			// 
			this.openFileVideo.FileName = "openFileDialog1";
			// 
			// btnBrowser
			// 
			this.btnBrowser.Location = new System.Drawing.Point(65, 193);
			this.btnBrowser.Name = "btnBrowser";
			this.btnBrowser.Size = new System.Drawing.Size(108, 30);
			this.btnBrowser.TabIndex = 3;
			this.btnBrowser.Text = "Browser";
			this.btnBrowser.UseVisualStyleBackColor = true;
			this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
			// 
			// btnConvert
			// 
			this.btnConvert.Location = new System.Drawing.Point(448, 193);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(126, 30);
			this.btnConvert.TabIndex = 4;
			this.btnConvert.Text = "Convert";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// process1
			// 
			this.process1.StartInfo.Domain = "";
			this.process1.StartInfo.LoadUserProfile = false;
			this.process1.StartInfo.Password = null;
			this.process1.StartInfo.StandardErrorEncoding = null;
			this.process1.StartInfo.StandardOutputEncoding = null;
			this.process1.StartInfo.UserName = "";
			this.process1.SynchronizingObject = this;
			// 
			// lbLoading
			// 
			this.lbLoading.AutoSize = true;
			this.lbLoading.Location = new System.Drawing.Point(179, 130);
			this.lbLoading.Name = "lbLoading";
			this.lbLoading.Size = new System.Drawing.Size(83, 13);
			this.lbLoading.TabIndex = 5;
			this.lbLoading.Text = "Descargando....";
			this.lbLoading.Visible = false;
			// 
			// VideoConverter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 266);
			this.Controls.Add(this.lbLoading);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.btnBrowser);
			this.Controls.Add(this.btnDownloadAudio);
			this.Controls.Add(this.btnDownload);
			this.Controls.Add(this.txbURL);
			this.Name = "VideoConverter";
			this.Text = "Video converter";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbURL;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnDownloadAudio;
        private System.Windows.Forms.OpenFileDialog openFileVideo;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnConvert;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Diagnostics.Process process1;
		private System.Windows.Forms.Label lbLoading;
	}
}

