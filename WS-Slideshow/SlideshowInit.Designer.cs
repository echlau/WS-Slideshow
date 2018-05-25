namespace WS_Slideshow
{
    partial class SlideshowInitialization
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
            this.panelNumber = new System.Windows.Forms.ComboBox();
            this.panelInterval1 = new System.Windows.Forms.TextBox();
            this.panelInterval2 = new System.Windows.Forms.TextBox();
            this.panelInterval3 = new System.Windows.Forms.TextBox();
            this.panelInterval4 = new System.Windows.Forms.TextBox();
            this.intervalGroup = new System.Windows.Forms.Panel();
            this.startSlideshow = new System.Windows.Forms.Button();
            this.intervalGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowse
            // 
            this.folderBrowse.Location = new System.Drawing.Point(626, 38);
            this.folderBrowse.Name = "folderBrowse";
            this.folderBrowse.Size = new System.Drawing.Size(96, 23);
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
            this.createFolders.Location = new System.Drawing.Point(626, 67);
            this.createFolders.Name = "createFolders";
            this.createFolders.Size = new System.Drawing.Size(96, 23);
            this.createFolders.TabIndex = 2;
            this.createFolders.Text = "Create Folders";
            this.createFolders.UseVisualStyleBackColor = true;
            this.createFolders.Click += new System.EventHandler(this.createFolders_Click);
            // 
            // panelNumber
            // 
            this.panelNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.panelNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.panelNumber.Location = new System.Drawing.Point(37, 106);
            this.panelNumber.Name = "panelNumber";
            this.panelNumber.Size = new System.Drawing.Size(121, 21);
            this.panelNumber.TabIndex = 3;
            this.panelNumber.SelectedIndexChanged += new System.EventHandler(this.panelNumber_SelectedIndexChanged);
            // 
            // panelInterval1
            // 
            this.panelInterval1.Location = new System.Drawing.Point(3, 12);
            this.panelInterval1.Name = "panelInterval1";
            this.panelInterval1.Size = new System.Drawing.Size(100, 20);
            this.panelInterval1.TabIndex = 4;
            this.panelInterval1.Text = "10";
            // 
            // panelInterval2
            // 
            this.panelInterval2.Enabled = false;
            this.panelInterval2.Location = new System.Drawing.Point(3, 94);
            this.panelInterval2.Name = "panelInterval2";
            this.panelInterval2.Size = new System.Drawing.Size(100, 20);
            this.panelInterval2.TabIndex = 5;
            this.panelInterval2.Text = "15";
            // 
            // panelInterval3
            // 
            this.panelInterval3.Enabled = false;
            this.panelInterval3.Location = new System.Drawing.Point(3, 178);
            this.panelInterval3.Name = "panelInterval3";
            this.panelInterval3.Size = new System.Drawing.Size(100, 20);
            this.panelInterval3.TabIndex = 6;
            this.panelInterval3.Text = "25";
            // 
            // panelInterval4
            // 
            this.panelInterval4.Enabled = false;
            this.panelInterval4.Location = new System.Drawing.Point(3, 260);
            this.panelInterval4.Name = "panelInterval4";
            this.panelInterval4.Size = new System.Drawing.Size(100, 20);
            this.panelInterval4.TabIndex = 7;
            this.panelInterval4.Text = "40";
            // 
            // intervalGroup
            // 
            this.intervalGroup.Controls.Add(this.panelInterval1);
            this.intervalGroup.Controls.Add(this.panelInterval2);
            this.intervalGroup.Controls.Add(this.panelInterval3);
            this.intervalGroup.Controls.Add(this.panelInterval4);
            this.intervalGroup.Location = new System.Drawing.Point(522, 106);
            this.intervalGroup.Name = "intervalGroup";
            this.intervalGroup.Size = new System.Drawing.Size(200, 295);
            this.intervalGroup.TabIndex = 8;
            // 
            // startSlideshow
            // 
            this.startSlideshow.Location = new System.Drawing.Point(626, 407);
            this.startSlideshow.Name = "startSlideshow";
            this.startSlideshow.Size = new System.Drawing.Size(96, 23);
            this.startSlideshow.TabIndex = 9;
            this.startSlideshow.Text = "Start Slideshow";
            this.startSlideshow.UseVisualStyleBackColor = true;
            this.startSlideshow.Click += new System.EventHandler(this.startSlideshow_Click);
            // 
            // SlideshowInitialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startSlideshow);
            this.Controls.Add(this.intervalGroup);
            this.Controls.Add(this.panelNumber);
            this.Controls.Add(this.createFolders);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.folderBrowse);
            this.Name = "SlideshowInitialization";
            this.Text = "WS-Slideshow";
            this.intervalGroup.ResumeLayout(false);
            this.intervalGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button folderBrowse;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.Button createFolders;
        private System.Windows.Forms.ComboBox panelNumber;
        private System.Windows.Forms.TextBox panelInterval1;
        private System.Windows.Forms.TextBox panelInterval2;
        private System.Windows.Forms.TextBox panelInterval3;
        private System.Windows.Forms.TextBox panelInterval4;
        private System.Windows.Forms.Panel intervalGroup;
        private System.Windows.Forms.Button startSlideshow;
    }
}

