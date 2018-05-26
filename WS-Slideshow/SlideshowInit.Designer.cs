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
            this.intervalGroup = new System.Windows.Forms.GroupBox();
            this.labelPanel4Seconds = new System.Windows.Forms.Label();
            this.labelPanel3Seconds = new System.Windows.Forms.Label();
            this.labelPanel2Seconds = new System.Windows.Forms.Label();
            this.labelPanel1Seconds = new System.Windows.Forms.Label();
            this.labelPanel4Interval = new System.Windows.Forms.Label();
            this.labelPanel3Interval = new System.Windows.Forms.Label();
            this.labelPanel2Interval = new System.Windows.Forms.Label();
            this.labelPanel1Interval = new System.Windows.Forms.Label();
            this.labelNumofPanel = new System.Windows.Forms.Label();
            this.startSlideshow = new System.Windows.Forms.Button();
            this.labelFolderPath = new System.Windows.Forms.Label();
            this.pathGroup = new System.Windows.Forms.GroupBox();
            this.intervalGroup.SuspendLayout();
            this.pathGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowse
            // 
            this.folderBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.folderBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderBrowse.Location = new System.Drawing.Point(617, 58);
            this.folderBrowse.Name = "folderBrowse";
            this.folderBrowse.Size = new System.Drawing.Size(142, 26);
            this.folderBrowse.TabIndex = 0;
            this.folderBrowse.Text = "Browse";
            this.folderBrowse.UseVisualStyleBackColor = true;
            this.folderBrowse.Click += new System.EventHandler(this.folderBrowse_Click);
            // 
            // folderPath
            // 
            this.folderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderPath.Location = new System.Drawing.Point(10, 58);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(601, 26);
            this.folderPath.TabIndex = 1;
            // 
            // createFolders
            // 
            this.createFolders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createFolders.Location = new System.Drawing.Point(617, 95);
            this.createFolders.Name = "createFolders";
            this.createFolders.Size = new System.Drawing.Size(142, 26);
            this.createFolders.TabIndex = 2;
            this.createFolders.Text = "Create Folders";
            this.createFolders.UseVisualStyleBackColor = true;
            this.createFolders.Click += new System.EventHandler(this.createFolders_Click);
            // 
            // panelNumber
            // 
            this.panelNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.panelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.panelNumber.Location = new System.Drawing.Point(152, 25);
            this.panelNumber.Name = "panelNumber";
            this.panelNumber.Size = new System.Drawing.Size(121, 28);
            this.panelNumber.TabIndex = 3;
            this.panelNumber.SelectedIndexChanged += new System.EventHandler(this.panelNumber_SelectedIndexChanged);
            // 
            // panelInterval1
            // 
            this.panelInterval1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelInterval1.Location = new System.Drawing.Point(6, 97);
            this.panelInterval1.MaxLength = 3;
            this.panelInterval1.Name = "panelInterval1";
            this.panelInterval1.Size = new System.Drawing.Size(100, 26);
            this.panelInterval1.TabIndex = 4;
            this.panelInterval1.Text = "10";
            // 
            // panelInterval2
            // 
            this.panelInterval2.Enabled = false;
            this.panelInterval2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelInterval2.Location = new System.Drawing.Point(6, 189);
            this.panelInterval2.MaxLength = 3;
            this.panelInterval2.Name = "panelInterval2";
            this.panelInterval2.Size = new System.Drawing.Size(100, 26);
            this.panelInterval2.TabIndex = 5;
            this.panelInterval2.Text = "10";
            // 
            // panelInterval3
            // 
            this.panelInterval3.Enabled = false;
            this.panelInterval3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelInterval3.Location = new System.Drawing.Point(366, 97);
            this.panelInterval3.MaxLength = 3;
            this.panelInterval3.Name = "panelInterval3";
            this.panelInterval3.Size = new System.Drawing.Size(100, 26);
            this.panelInterval3.TabIndex = 6;
            this.panelInterval3.Text = "10";
            // 
            // panelInterval4
            // 
            this.panelInterval4.Enabled = false;
            this.panelInterval4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelInterval4.Location = new System.Drawing.Point(366, 189);
            this.panelInterval4.MaxLength = 3;
            this.panelInterval4.Name = "panelInterval4";
            this.panelInterval4.Size = new System.Drawing.Size(100, 26);
            this.panelInterval4.TabIndex = 7;
            this.panelInterval4.Text = "10";
            // 
            // intervalGroup
            // 
            this.intervalGroup.Controls.Add(this.labelPanel4Seconds);
            this.intervalGroup.Controls.Add(this.labelPanel3Seconds);
            this.intervalGroup.Controls.Add(this.labelPanel2Seconds);
            this.intervalGroup.Controls.Add(this.labelPanel1Seconds);
            this.intervalGroup.Controls.Add(this.labelPanel4Interval);
            this.intervalGroup.Controls.Add(this.labelPanel3Interval);
            this.intervalGroup.Controls.Add(this.labelPanel2Interval);
            this.intervalGroup.Controls.Add(this.labelPanel1Interval);
            this.intervalGroup.Controls.Add(this.labelNumofPanel);
            this.intervalGroup.Controls.Add(this.panelInterval1);
            this.intervalGroup.Controls.Add(this.panelInterval2);
            this.intervalGroup.Controls.Add(this.panelInterval3);
            this.intervalGroup.Controls.Add(this.panelNumber);
            this.intervalGroup.Controls.Add(this.panelInterval4);
            this.intervalGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.intervalGroup.Location = new System.Drawing.Point(12, 153);
            this.intervalGroup.Name = "intervalGroup";
            this.intervalGroup.Size = new System.Drawing.Size(776, 253);
            this.intervalGroup.TabIndex = 8;
            this.intervalGroup.TabStop = false;
            this.intervalGroup.Text = "Step 2 - Panels and Slide Intervals";
            // 
            // labelPanel4Seconds
            // 
            this.labelPanel4Seconds.AutoSize = true;
            this.labelPanel4Seconds.Location = new System.Drawing.Point(472, 192);
            this.labelPanel4Seconds.Name = "labelPanel4Seconds";
            this.labelPanel4Seconds.Size = new System.Drawing.Size(72, 20);
            this.labelPanel4Seconds.TabIndex = 17;
            this.labelPanel4Seconds.Text = "Seconds";
            // 
            // labelPanel3Seconds
            // 
            this.labelPanel3Seconds.AutoSize = true;
            this.labelPanel3Seconds.Location = new System.Drawing.Point(472, 100);
            this.labelPanel3Seconds.Name = "labelPanel3Seconds";
            this.labelPanel3Seconds.Size = new System.Drawing.Size(72, 20);
            this.labelPanel3Seconds.TabIndex = 16;
            this.labelPanel3Seconds.Text = "Seconds";
            // 
            // labelPanel2Seconds
            // 
            this.labelPanel2Seconds.AutoSize = true;
            this.labelPanel2Seconds.Location = new System.Drawing.Point(112, 192);
            this.labelPanel2Seconds.Name = "labelPanel2Seconds";
            this.labelPanel2Seconds.Size = new System.Drawing.Size(72, 20);
            this.labelPanel2Seconds.TabIndex = 15;
            this.labelPanel2Seconds.Text = "Seconds";
            // 
            // labelPanel1Seconds
            // 
            this.labelPanel1Seconds.AutoSize = true;
            this.labelPanel1Seconds.Location = new System.Drawing.Point(112, 100);
            this.labelPanel1Seconds.Name = "labelPanel1Seconds";
            this.labelPanel1Seconds.Size = new System.Drawing.Size(72, 20);
            this.labelPanel1Seconds.TabIndex = 13;
            this.labelPanel1Seconds.Text = "Seconds";
            // 
            // labelPanel4Interval
            // 
            this.labelPanel4Interval.AutoSize = true;
            this.labelPanel4Interval.Location = new System.Drawing.Point(366, 166);
            this.labelPanel4Interval.Name = "labelPanel4Interval";
            this.labelPanel4Interval.Size = new System.Drawing.Size(66, 20);
            this.labelPanel4Interval.TabIndex = 12;
            this.labelPanel4Interval.Text = "Panel 4:";
            // 
            // labelPanel3Interval
            // 
            this.labelPanel3Interval.AutoSize = true;
            this.labelPanel3Interval.Location = new System.Drawing.Point(366, 74);
            this.labelPanel3Interval.Name = "labelPanel3Interval";
            this.labelPanel3Interval.Size = new System.Drawing.Size(66, 20);
            this.labelPanel3Interval.TabIndex = 11;
            this.labelPanel3Interval.Text = "Panel 3:";
            // 
            // labelPanel2Interval
            // 
            this.labelPanel2Interval.AutoSize = true;
            this.labelPanel2Interval.Location = new System.Drawing.Point(7, 166);
            this.labelPanel2Interval.Name = "labelPanel2Interval";
            this.labelPanel2Interval.Size = new System.Drawing.Size(66, 20);
            this.labelPanel2Interval.TabIndex = 10;
            this.labelPanel2Interval.Text = "Panel 2:";
            // 
            // labelPanel1Interval
            // 
            this.labelPanel1Interval.AutoSize = true;
            this.labelPanel1Interval.Location = new System.Drawing.Point(6, 74);
            this.labelPanel1Interval.Name = "labelPanel1Interval";
            this.labelPanel1Interval.Size = new System.Drawing.Size(66, 20);
            this.labelPanel1Interval.TabIndex = 9;
            this.labelPanel1Interval.Text = "Panel 1:";
            // 
            // labelNumofPanel
            // 
            this.labelNumofPanel.AutoSize = true;
            this.labelNumofPanel.Location = new System.Drawing.Point(7, 26);
            this.labelNumofPanel.Name = "labelNumofPanel";
            this.labelNumofPanel.Size = new System.Drawing.Size(139, 20);
            this.labelNumofPanel.TabIndex = 8;
            this.labelNumofPanel.Text = "Number of Panels:";
            // 
            // startSlideshow
            // 
            this.startSlideshow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startSlideshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSlideshow.Location = new System.Drawing.Point(629, 412);
            this.startSlideshow.Name = "startSlideshow";
            this.startSlideshow.Size = new System.Drawing.Size(142, 26);
            this.startSlideshow.TabIndex = 9;
            this.startSlideshow.Text = "Start Slideshow";
            this.startSlideshow.UseVisualStyleBackColor = true;
            this.startSlideshow.Click += new System.EventHandler(this.startSlideshow_Click);
            // 
            // labelFolderPath
            // 
            this.labelFolderPath.AutoSize = true;
            this.labelFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFolderPath.Location = new System.Drawing.Point(6, 35);
            this.labelFolderPath.Name = "labelFolderPath";
            this.labelFolderPath.Size = new System.Drawing.Size(95, 20);
            this.labelFolderPath.TabIndex = 10;
            this.labelFolderPath.Text = "Folder Path:";
            // 
            // pathGroup
            // 
            this.pathGroup.Controls.Add(this.folderPath);
            this.pathGroup.Controls.Add(this.labelFolderPath);
            this.pathGroup.Controls.Add(this.folderBrowse);
            this.pathGroup.Controls.Add(this.createFolders);
            this.pathGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pathGroup.Location = new System.Drawing.Point(12, 12);
            this.pathGroup.Name = "pathGroup";
            this.pathGroup.Size = new System.Drawing.Size(776, 135);
            this.pathGroup.TabIndex = 11;
            this.pathGroup.TabStop = false;
            this.pathGroup.Text = "Step 1 - Location";
            // 
            // SlideshowInitialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pathGroup);
            this.Controls.Add(this.startSlideshow);
            this.Controls.Add(this.intervalGroup);
            this.Name = "SlideshowInitialization";
            this.Text = "WS-Slideshow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SlideshowInitialization_FormClosed);
            this.intervalGroup.ResumeLayout(false);
            this.intervalGroup.PerformLayout();
            this.pathGroup.ResumeLayout(false);
            this.pathGroup.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox intervalGroup;
        private System.Windows.Forms.Button startSlideshow;
        private System.Windows.Forms.Label labelFolderPath;
        private System.Windows.Forms.GroupBox pathGroup;
        private System.Windows.Forms.Label labelPanel4Seconds;
        private System.Windows.Forms.Label labelPanel3Seconds;
        private System.Windows.Forms.Label labelPanel2Seconds;
        private System.Windows.Forms.Label labelPanel1Seconds;
        private System.Windows.Forms.Label labelPanel4Interval;
        private System.Windows.Forms.Label labelPanel3Interval;
        private System.Windows.Forms.Label labelPanel2Interval;
        private System.Windows.Forms.Label labelPanel1Interval;
        private System.Windows.Forms.Label labelNumofPanel;
    }
}

