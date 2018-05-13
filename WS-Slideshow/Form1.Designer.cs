namespace WS_Slideshow
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowse = new System.Windows.Forms.Button();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.createFolders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderBrowse
            // 
            this.folderBrowse.Location = new System.Drawing.Point(639, 38);
            this.folderBrowse.Name = "folderBrowse";
            this.folderBrowse.Size = new System.Drawing.Size(83, 23);
            this.folderBrowse.TabIndex = 0;
            this.folderBrowse.Text = "Browse";
            this.folderBrowse.UseVisualStyleBackColor = true;
            this.folderBrowse.Click += new System.EventHandler(this.folderBrowse_Click);
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(37, 40);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(580, 20);
            this.folderPath.TabIndex = 1;
            this.folderPath.Text = "C:\\Users\\EricL\\OneDrive";
            // 
            // createFolders
            // 
            this.createFolders.Location = new System.Drawing.Point(639, 67);
            this.createFolders.Name = "createFolders";
            this.createFolders.Size = new System.Drawing.Size(83, 23);
            this.createFolders.TabIndex = 2;
            this.createFolders.Text = "Create Folders";
            this.createFolders.UseVisualStyleBackColor = true;
            this.createFolders.Click += new System.EventHandler(this.createFolders_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createFolders);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.folderBrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button folderBrowse;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.Button createFolders;
    }
}

