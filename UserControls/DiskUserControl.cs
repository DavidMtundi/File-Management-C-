using AdvancedProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdvancedProject.UserControls
{
    public partial class DiskUserControl : UserControl
    {
        public DiskUserControl()
        {
            InitializeComponent();
        }
        #region Properties
        private String disktitle;
        private String totspace;
        private String used;

        /// get and setter vallues
        [Category("Disk props")]
        public String Diskname
        {

            get { return disktitle; }
            set { disktitle = value;drivename.Text = value; }

        }
        [Category("Disk props")]

        public String Totalspace
        {
            get { return totspace; }
            set { totspace = value; labeltotalspace.Text = value; }

        }
        [Category("Disk props")]

        public String UsedSpace
        {
            get { return used; }
            set { used = value;labelusedspace.Text = value; }

        } 
        #endregion

        private void DiskUserControl_MouseEnter(object sender, EventArgs e)
        {
           // this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void DiskUserControl_MouseLeave(object sender, EventArgs e)
        {
          //  this.BackColor = Color.FromArgb(255, 255, 255);

        }

        private void DiskUserControl_MouseHover(object sender, EventArgs e)
        {
           // this.BackColor = Color.FromArgb(217, 229, 242);

        }

        private void drivename_Click(object sender, EventArgs e)
        {

        }

        private void DiskUserControl_Load(object sender, EventArgs e)
        {

        }

        private void DiskUserControl_MouseClick(object sender, MouseEventArgs e)
        {
          //  displayfiledisk();
        }

        private void displayfiledisk()
        {
           SecondForm files = new SecondForm();
            //Utilities.diskpath = drivename.Text.ToString();
           // files.labelpartitionname.Text = drivename.Text.ToString();
            files.ShowDialog();
        }

        private void DiskUserControl_Click(object sender, EventArgs e)
        {
            displayfiledisk();
        }

        private void DiskUserControl_DoubleClick(object sender, EventArgs e)
        {
            displayfiledisk();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            FileAccess.selecteddisk = drivename.Text.ToString();
            displayfiledisk();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
