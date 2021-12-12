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
    public partial class OpenApp : Form
    {
        public OpenApp()
        {
            InitializeComponent();
        }
        string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
        private void OpenApp_Load(object sender, EventArgs e)
        {
            Utilities.loadallinstalledapplications(metroGrid1);
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
                    pname = row.Cells[0].Value.ToString();
                }
                //confirm end of the process
                //if yes then end the processs
                try
                {
                    Process.Start (uninstallKey+pname);
                    
                  //  MessageBox.Show(pname + " terminated successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //TODO - Button Clicked - Execute Code Here
            }
        }
    }
}
