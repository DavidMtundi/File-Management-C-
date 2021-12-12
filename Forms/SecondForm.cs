using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdvancedProject.Forms
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private void paneldocs_Click(object sender, EventArgs e)
        {
            AllDocsForm aud = new AllDocsForm();
            aud.ShowDialog();
        }

        private void panelvideos_Click(object sender, EventArgs e)
        {
            
            AllVideosForm aud = new AllVideosForm();
            aud.ShowDialog();
        }

        private void panelaudios_Click(object sender, EventArgs e)
        {
            AudioForm aud = new AudioForm();
          aud.ShowDialog();
        }

        private void panelzipped_Click(object sender, EventArgs e)
        {
            AllZippedForms aud = new AllZippedForms();
            aud.ShowDialog();
        }

        private void panelexecs_Click(object sender, EventArgs e)
        {
            AllExecutablesForm aud = new AllExecutablesForm();
            aud.ShowDialog();
        }

        private void panelfolders_Click(object sender, EventArgs e)
        {
            AllFoldersForm frm = new AllFoldersForm();
            frm.ShowDialog();
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
            FileAccess.loadallfilesanddirectories(FileAccess.selecteddisk.ToString());
            fillinthedetails();
            
        }

        private void fillinthedetails()
        {
            labelfilespartition.Text = FileAccess.selecteddisk.ToString();
            labelallaudios.Text = (FileAccess.allaudios).ToString();
            labelalldocuments.Text = (FileAccess.alldocuments).ToString();
            labelallexecutables.Text =( FileAccess.allexecutables).ToString();
            labelallfolders.Text = (FileAccess.allfolders.ToString());
            labelallvideos.Text = (FileAccess.allvideos).ToString();
            labelallzippedfiles.Text =( FileAccess.allzipped).ToString();
        }
    }
}
