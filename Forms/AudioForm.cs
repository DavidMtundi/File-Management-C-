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
    public partial class AudioForm : Form
    {
        public AudioForm()
        {
            InitializeComponent();
        }

        private void AudioForm_Load(object sender, EventArgs e)
        {
            FileAccess.grid = metroGrid1;

            FileAccess.loadallaudiofiles(FileAccess.selecteddisk.ToString());
        }

        private void btnmove_Click(object sender, EventArgs e)
        {
            Utilities.getdatagridvaluesandopensmalldialogue(metroGrid1, "move");
            FileAccess.loadallaudiofiles(FileAccess.selecteddisk.ToString());

        }

        private void btncopy_Click(object sender, EventArgs e)
        {
            Utilities.getdatagridvaluesandopensmalldialogue(metroGrid1, "copy");
            FileAccess.loadallaudiofiles(FileAccess.selecteddisk.ToString());

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count>1)
            {
                Utilities.getdatagridvaluesandopensmalldialogue(metroGrid1, "delete");
                FileAccess.loadallaudiofiles(FileAccess.selecteddisk.ToString());
                Utilities.unselectselecteddatagridrows(metroGrid1);
            }
            else
            {
                Utilities.deleteonefile(metroGrid1);
            }

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
            }//  FileAccess.openclickeddatagridcell(metroGrid1);

        }

        private void metroGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FileAccess.openclickeddatagridcell(metroGrid1);

        }
    }
}
