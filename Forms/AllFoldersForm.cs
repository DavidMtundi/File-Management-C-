using AdvancedProject.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdvancedProject.Forms
{
    public partial class AllFoldersForm : Form
    {
        public AllFoldersForm()
        {
            InitializeComponent();
        }

        private void AllPdfsForm_Load(object sender, EventArgs e)
        {
            // panel1.Controls.Add(new AllFiles());
            FileAccess.loadallfolders(metroGrid1);
        }

        private void metroGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FileAccess.openclickeddatagridcell(metroGrid1);

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;


            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                try
                {
                    Utilities.deleteonefile(metroGrid1);
                    // MessageBox.Show(pname + " terminated successfully");
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
