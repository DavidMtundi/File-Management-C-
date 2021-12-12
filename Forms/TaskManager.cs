using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdvancedProject.Forms
{
    public partial class TaskManager : Form
    {
        public TaskManager()
        {
            InitializeComponent();
        }

        private void TaskManager_Load(object sender, EventArgs e)
        {
            Utilities.loadallprocesesrunningnotbackground(metroGrid1);
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string pname = "";

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in metroGrid1.SelectedRows)
                {
                   pname= row.Cells[0].Value.ToString();
                }
                //confirm end of the process
                //if yes then end the processs
                try
                {
                    Process[] proc= Process.GetProcessesByName(pname);
                    proc[0].Kill();
                    MessageBox.Show(pname + " terminated successfully");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //TODO - Button Clicked - Execute Code Here
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenApp app = new OpenApp();
            app.ShowDialog();
        }
    }
}
