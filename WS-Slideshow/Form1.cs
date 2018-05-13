using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace WS_Slideshow
{
    public partial class Form1 : Form
    {
        private static String slideShowFolderPath;
        public Form1()
        {
            InitializeComponent();
        }
        //Browse for folder where slides will be held
        private void folderBrowse_Click(object sender, EventArgs e)
        {
            //Displays dialog for user to select folder
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Sets the folderPath textbox to the path selected
                folderPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void createFolders_Click(object sender, EventArgs e)
        {
            //Sets static variable slideShowFolderPath to the folder to where the slides will be held
            slideShowFolderPath = folderPath.Text;
            if (Directory.Exists(slideShowFolderPath))
            //Creates folders to use for different panels in the slide show
            {
                for (int i = 1; i <= 4; i++)
                {
                    Directory.CreateDirectory(slideShowFolderPath + "\\WS-Slideshow\\panel" + i);
                }
            }else
            {
                //Error for an incorrect file path
                Debug.Print("Incorrect file path");
            }

        }
    }
}
