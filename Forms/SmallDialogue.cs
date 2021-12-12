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
    public partial class SmallDialogue : Form
    {
        public SmallDialogue()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog op = new OpenFileDialog();
            //op.ShowDialog();
            Utilities.openfolderdialogue(txtdestination);

        }

        private void btnproceed_Click(object sender, EventArgs e)
        {
            if(txtfoldername.Text != null)
            {
                try
                {
                    FileAccess.Createfoldernamed(txtdestination.Text.ToString(), txtfoldername.Text.ToString());
                    Utilities.performnecessaryoperation();
                }
                catch (Exception)
                {                  
                    MessageBox.Show("Folder not created");
                }
            }
            this.Close();
        }

       

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
