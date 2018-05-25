﻿using System;
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
        private static List<PictureBox> panel = new List<PictureBox>();
        private static List<int> panelIndex = new List<int>();
        private static Size screenSize;
        private static Timer panelTimer = new Timer();
        private static List<int> panelTime = new List<int>();
        
        //Using a timer event to changes slides for panel
        private static void TimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            //Sets timer to tick every second.
            panelTimer.Interval = 1000;
            for (int i = 0; i < numofPanels; i++)
            { 
                List<String> dirs = new List<string>();
                dirs.Clear();
                foreach(String s in Directory.GetFiles(folderPath + "\\panel" + (i + 1), "*.jpg")) {
                    dirs.Add(s);
                }
                foreach (String s in Directory.GetFiles(folderPath + "\\panel" + (i + 1), "*.png"))
                {
                    dirs.Add(s);
                }
                if (panelTime[i] == 0)
                {
                    //Checks if panel index exceeds the number of slides in the folder
                    if (panelIndex[i] >= dirs.Count)
                    {
                        //Sets the index to the first slide
                        panelIndex[i] = 0;
                    }
                    try
                    {
                        //Displays the slide in the corresponding panel
                        panel[i].ImageLocation = dirs[panelIndex[i]++];
                    }
                    catch
                    {
                        //endSlideshow();
                    }
                    //Sets the time remaining of the panel to the correct 
                    panelTime[i] = intervalofPanels[i];
                }else
                {
                    //Updates the time remaining for a slide change
                    panelTime[i]--;
                }
            }
            ///TEMP END
        }

        //Exits out of the slideshow
        private static void endSlideshow()
        {
            //Stops timer event and closes slideshow
            panelTimer.Stop();
            panelTimer.Enabled = false;
            if (Application.OpenForms.OfType<Slideshow>().Count() > 0)
                Application.OpenForms.OfType<Slideshow>().First().Close();
        }

        //Sets up slideshows and sets values for static variables
        public Slideshow(int num, List<int> intervals, string path)
        {
            InitializeComponent();
            numofPanels = num;
            intervalofPanels = intervals;
            folderPath = path;
            screenSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            
            //Calls methods to set up panels and starts the slideshow
            referencePanels();
            resetPanels();
            adjustPanels(num);
            startSlideshow(num);
        }

        //Sets pictureBox references to be accessed by static methods
        private void referencePanels()
        {
            if (panel.Count > 0)
            {
                panel.Clear();
            }
            panel.Add(pictureBox1);
            panel.Add(pictureBox2);
            panel.Add(pictureBox3);
            panel.Add(pictureBox4);
        }
        
        //Sets all panels to first slide
        private void resetPanels()
        {
            if (panelIndex.Count > 0)
            {
                panelIndex.Clear();
            }
            if (panelTime.Count > 0)
            {
                panelTime.Clear();
            }
            for (int i = 0; i < 4; i++)
            {
                panelIndex.Add(0);
                panelTime.Add(0);
            }
        }

        //Adjusts the size and location of the panels to match the number of panels selected
        private void adjustPanels(int num)
        {
            switch (num)
            {
                case 1:
                    pictureBox1.Size = screenSize;
                    break;
                case 2:
                    pictureBox1.Size = new Size(screenSize.Width, screenSize.Height / 2);
                    pictureBox2.Size = new Size(screenSize.Width, screenSize.Height / 2);

                    pictureBox2.Location = new Point(0, screenSize.Height / 2);
                    break;
                case 3:
                    pictureBox1.Size = new Size(screenSize.Width, screenSize.Height / 2);
                    pictureBox2.Size = new Size(screenSize.Width / 2, screenSize.Height / 2);
                    pictureBox3.Size = new Size(screenSize.Width / 2, screenSize.Height / 2);

                    pictureBox2.Location = new Point(0, screenSize.Height / 2);
                    pictureBox3.Location = new Point(screenSize.Width / 2, screenSize.Height / 2);
                    break;
                case 4:
                    pictureBox1.Size = new Size(screenSize.Width / 2, screenSize.Height / 2);
                    pictureBox2.Size = new Size(screenSize.Width / 2, screenSize.Height / 2);
                    pictureBox3.Size = new Size(screenSize.Width / 2, screenSize.Height / 2);
                    pictureBox4.Size = new Size(screenSize.Width / 2, screenSize.Height / 2);

                    pictureBox2.Location = new Point(0, screenSize.Height / 2);
                    pictureBox3.Location = new Point(screenSize.Width / 2, screenSize.Height / 2);
                    pictureBox4.Location = new Point(screenSize.Width / 2, 0);
                    break;
            }
        }

        private void startSlideshow(int num)
        {
            panelTimer = new Timer();
            panelTimer.Tick += new EventHandler(TimerEventProcessor);
            panelTimer.Interval = 1;
            panelTimer.Enabled = true;
            panelTimer.Start();
            
        }

        //Closes slideshow on escape key press
        private void Slideshow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Slideshow_FormClosed(sender, new FormClosedEventArgs(new CloseReason()));
            }
        }

        //Ensures the timer is stopped when form is closed
        private void Slideshow_FormClosed(object sender, FormClosedEventArgs e)
        {
            endSlideshow();
        }
    }
}
