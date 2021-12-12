using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AdvancedProject.UserControls
{
    public partial class HomeUserControl : UserControl
    {
        DriveInfo[] drives;

        public HomeUserControl()
        {
            InitializeComponent();
            drives = DriveInfo.GetDrives();

        }

        private void HomeUserControl_Load(object sender, EventArgs e)
        {
            loadallDrives();

        }
        private void loadallDrives()
        {
            for (int i = 0; i < drives.Length; i++)
            {
                if (drives[i].IsReady)
                {
                    int defaultprogress = 100;
                    int defaultstorage = 500;

                    DiskUserControl us = new DiskUserControl();
                    us.labeltotalspace.Text = (double.Parse(drives[i].TotalSize.ToString()) / 1000000000).ToString().Substring(0, 5) + "GB";

                    us.labelusedspace.Text = ((double.Parse(drives[i].AvailableFreeSpace.ToString()) / 1000000000)).ToString().Substring(0, 4) + "GB";
                    us.drivename.Text = drives[i].Name.ToUpper().ToString();
                    us.progressbardrivespace.Value = defaultprogress;
                    us.progressbardrivespace.Maximum = defaultstorage;

                    us.Dock = DockStyle.Top;
                    //  us.disktitle = drives[i].Name.ToUpper().ToString();
                    //  us.totspace = (double.Parse(drives[i].TotalSize.ToString()) / 1000000000).ToString() + "GB";
                    //  us.used = (double.Parse(drives[i].AvailableFreeSpace.ToString()) / 1000000000).ToString() + "GB";

                    // Adding this button to form
                    paneldrives.Controls.Add(us);
                    //this.Controls.Add(us);
                }
                else
                {
                    i++;

                }
            }
        }
    }
}
