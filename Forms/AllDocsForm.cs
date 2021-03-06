using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdvancedProject.Forms
{
    public partial class AllDocsForm : Form
    {
        public AllDocsForm()
        {
            InitializeComponent();
        }

        private void AllDocsForm_Load(object sender, EventArgs e)
        {
            FileAccess.grid = metroGrid1;

            FileAccess.loadalldocumentsfiles(FileAccess.selecteddisk.ToString());
        }

        private void btnmove_Click(object sender, EventArgs e)
        {
            Utilities.getdatagridvaluesandopensmalldialogue(metroGrid1, "move");
        }

        private void btncopy_Click(object sender, EventArgs e)
        {
            Utilities.getdatagridvaluesandopensmalldialogue(metroGrid1, "copy");

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Utilities.getdatagridvaluesandopensmalldialogue(metroGrid1, "delete");

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

        private void metroGrid1_Enter(object sender, EventArgs e)
        {
           // PreviewForm pv = new PreviewForm();
          //  Utilities.loadworddocumentsinrichtextbox(pv.richTextBox1,metroGrid1.SelectedRows[0].Cells[2].Value.ToString());
            //pv.Show();
        }

        private void metroGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FileAccess.openclickeddatagridcell(metroGrid1);

        }
    }
}
