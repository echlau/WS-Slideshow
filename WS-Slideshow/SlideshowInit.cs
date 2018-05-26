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
using System.Configuration;

namespace WS_Slideshow
{
    public partial class SlideshowInitialization : Form
    {
        //Path where the images/slides are located
        private static String slideShowFolderPath;
        //Array of intervals for the specific panels
        private static List<int> intervalofPanels = new List<int>();
        //Form of the slideshow presentation
        private static Slideshow slideshow;

        public SlideshowInitialization()
        {
            InitializeComponent();

            //Loads what user had last session
            panelNumber.Text  = Properties.Settings.Default.panelNumber;
            panelInterval2.Text = Properties.Settings.Default.panelInterval2;
            panelInterval3.Text = Properties.Settings.Default.panelInterval3;
            panelInterval4.Text = Properties.Settings.Default.panelInterval4;
            panelInterval1.Text = Properties.Settings.Default.panelInterval1;
            folderPath.Text = Properties.Settings.Default.folderPath;

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

        //Creates the directory where the images/slides are placed
        private void createFolders_Click(object sender, EventArgs e)
        {
            //Sets static variable slideShowFolderPath to the folder to where the slides will be held
            slideShowFolderPath = folderPath.Text;
            if (Directory.Exists(slideShowFolderPath))
            //Creates folders to use for different panels in the slide show
            {
                slideShowFolderPath += "\\WS-Slideshow";
                for (int i = 1; i <= 4; i++)
                {
                    Directory.CreateDirectory(slideShowFolderPath + "\\panel" + i);
                }
            }
            else
            {
                //Error for an incorrect file path
                Debug.Print("Incorrect file path format");
            }

        }
        //Enables/Disables textbox controls where user inputs the intervals for specific panels
        private void panelNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            //panelInterval textboxes enabled corresponding to number of panels chosen
            List<TextBox> intervals = new List<TextBox>(intervalGroup.Controls.OfType<TextBox>());
            for (int i = 0; i < 4; i++)
            {
                if (Int16.Parse(panelNumber.Text) > i)
                {
                    intervals[i].Enabled = true;
                }
                else
                {
                    intervals[i].Enabled = false;
                }
            }

        }
        //Button event that starts the slideshow
        private void startSlideshow_Click(object sender, EventArgs e)
        {
            //Resets all intervals
            intervalofPanels.Clear();
            //Only allows for one slideshow to be open
            if (Application.OpenForms.OfType<Slideshow>().Count() == 1)
                Application.OpenForms.OfType<Slideshow>().First().Close();

            //Put panel intervals set by user into an array
            for (int i = 0; i < Int16.Parse(panelNumber.Text); i++)
            {
                intervalofPanels.Add(Int16.Parse(intervalGroup.Controls[i].Text));
            }

            //Sets correct path
            slideShowFolderPath = folderPath.Text + "\\WS-Slideshow";
            if (Directory.Exists(slideShowFolderPath))
            {
                //Opens the slideshow form
                slideshow = new Slideshow(Int16.Parse(panelNumber.Text), intervalofPanels, slideShowFolderPath);
                slideshow.Show();
            }
        }
        

        private void SlideshowInitialization_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Saves fields of what the user had last before close
            Properties.Settings.Default.panelNumber = panelNumber.Text;
            Properties.Settings.Default.panelInterval1 = panelInterval1.Text;
            Properties.Settings.Default.panelInterval2 = panelInterval2.Text;
            Properties.Settings.Default.panelInterval3 = panelInterval3.Text;
            Properties.Settings.Default.panelInterval4 = panelInterval4.Text;
            Properties.Settings.Default.folderPath = folderPath.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
        }
    }
}
