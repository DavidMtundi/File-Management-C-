using AdvancedProject.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AdvancedProject.Forms
{
    public partial class AllPartitions : Form
    {
        string[] drs;
        List<String[]> alldrs = new List<string[]>();
        int allaudios, allvideos, alldocuments, allzipped, allduplicates, allexecutables, allfiles, allfolders, allunkwons = 0;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
            
        }

        private void htmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            TaskManager tsk = new TaskManager();
            tsk.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            SocketProgramming sc = new SocketProgramming();
            sc.ShowDialog();
        }

        public AllPartitions()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this populates the data and labels in the form
        /// </summary>
        private void populateform()
        {
            foreach (var item in alldrs)
            {
                foreach (var dir in item)
                {
                    allfolders += 1;
                }
            }
            allfiles = allfolders + allaudios + alldocuments + allexecutables + allzipped + allvideos + allunkwons;
       
        }

        private void AllFilesForm_Load(object sender, EventArgs e)
        {
            ///it should load all the harddisks and display them in the screen i.e C:// and many others.
            ///
            loadalldrives();
          //  loadallfilesanddirectories("C:\\");
          //  populateform();
        }
        private void loadallfiles(string v)
        {
            try
            {
                String[] filesgot = Directory.GetFiles(v);
                foreach (var item in filesgot)
                {
                
                    if ((Path.GetExtension(item) == ".mp4") || (Path.GetExtension(item) == ".mkv"))
                    {
                        allvideos += 1;
                    }
                    else if ((Path.GetExtension(item) == ".docx") || (Path.GetExtension(item) == ".pdf"))
                    {
                        alldocuments += 1;
                    }
                    else if ((Path.GetExtension(item) == ".exe"))
                    {
                        allexecutables += 1;
                    }
                    else if ((Path.GetExtension(item) == ".mp3") || (Path.GetExtension(item) == ".mkv"))
                    {
                        allaudios += 1;
                    }
                    else if ((Path.GetExtension(item) == ".zip"))
                    {
                        allzipped += 1;
                    }
                    else
                    {
                        allunkwons += 1;
                    }
                }
            }
            catch (Exception)
            {

                // throw;
            }
        }
        /// <summary>
        /// loads all the files and files in subdirectories in the given path
        /// </summary>
        /// <param name="v"></param>
        private void loadallfilesanddirectories(string v)
        {
            foreach (var item in loadalldirectories(v))
            {
                foreach (var item1 in item)
                {
                    loadallfiles(item1);

                }
            }
        }

        /// <summary>
        /// THIS LOADS ALL DIRECTORIES IN A GIVEN PATH
        /// </summary>
        /// <param name="v">< /param>
        private List<string[]> loadalldirectories(string v)
        {
            string[] drs = Directory.GetDirectories(v);
            alldrs.Add(drs);

            foreach (var stringgot in drs)
            {
                try
                {
                    if (Directory.GetDirectories(stringgot) != null)
                    {
                        loadalldirectories(stringgot);
                    }
                }
                catch (Exception)
                {

                    // throw;
                }
                // dataGridView1.Columns.Add(stringgot,stringgot);
            }
            return alldrs;
        }

        private void loadalldrives()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
               

                DiskUserControl us = new DiskUserControl();
                us.Diskname = d.Name.ToUpper().ToString();
                
                //Console.WriteLine("Drive {0}", d.Name);
               // Console.WriteLine("  Drive type: {0}", d.DriveType);
                if (d.IsReady == true)
                {
                    double freespace = d.TotalFreeSpace;
                    double totalspace = d.TotalSize;
                    int percentFree = (int)((freespace / totalspace) * 100);
                    int percentage = 100;
                    us.labeltotalspace.Text = (double.Parse(d.TotalSize.ToString()) / 1000000000).ToString().Substring(0, 5) + "GB";

                    us.labelusedspace.Text = ((double.Parse(d.AvailableFreeSpace.ToString()) / 1000000000)).ToString().Substring(0, 4) + "GB";
                    us.progressbardrivespace.Value = percentFree;
                    us.progressbardrivespace.Maximum = percentage;

                }
                toplayoutpanel.Controls.Add(us);
                
                
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
