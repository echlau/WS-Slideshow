using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WS_Slideshow
{
    public partial class Slideshow : Form
    {
        private static int numofPanels;
        private static List<int> intervalofPanels;
        private static String folderPath;
        private static Timer panelTimer1;
        private static PictureBox p;
        private static int temp = 0;
        //Changes slides for panel

        private static void TimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            ///TEMP START
            panelTimer1.Interval = intervalofPanels[0] * 1000;
            String[] dirs = Directory.GetFiles(folderPath + "\\panel1", "*.jpg");
            if (temp == dirs.Length)
            {
                temp = 0;
            }
            try
            {
                p.ImageLocation = dirs[temp++];
                Debug.Print(temp.ToString());
            }
            catch
            {
                endSlideshow();
            }
            ///TEMP END
        }

        //Exits out of the slideshow
        private static void endSlideshow()
        {
            panelTimer1.Stop();
            Application.OpenForms.OfType<Slideshow>().First().Close();
        }

        //Sets up slideshows and sets values for static variables
        public Slideshow(int num, List<int> intervals, string path)
        {
            InitializeComponent();
            numofPanels = num;
            intervalofPanels = intervals;
            folderPath = path;

            ///TEMP START
            temp = 0;
            p = pictureBox1;

            pictureBox1.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            panelTimer1 = new Timer();
            panelTimer1.Tick += new EventHandler(TimerEventProcessor);
            panelTimer1.Interval = 1;

            panelTimer1.Enabled = true;
            panelTimer1.Start();
            ///TEMP END
        }

        //Ensures the timer is stopped when form is closed
        private void Slideshow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Debug.Print("closing form");
            panelTimer1.Enabled = false;
            panelTimer1.Stop();
        }
        //Closes slideshow on escape key press
        private void Slideshow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                endSlideshow();
            }
        }
    }
}
