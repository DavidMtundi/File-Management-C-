using AdvancedProject.Forms;
using AdvancedProject.UserControls;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedProject
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private UserControl currentusercontrol;
        String[] drs;
        List<string[]> alldrs = new List<string[]>();
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            // Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Builder
      
        // Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn!= null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(UserControl usercontrol,String text)
        {
            // open only form
            panelDesktop.Controls.Clear();

           // usercontrol.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(usercontrol);
          //  panelDesktop.Tag = usercontrol;
            //usercontrol.BringToFront();
            // usercontrol.Show();
            panelDesktop.Show();
            lblTitleChildForm.Text = text;
           // panelDesktop.BringToFront();

        }
        private void OpenChildForm(Form childForm)
        {
            // open only form
            if (currentChildForm!= null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            // End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            ///if (currentChildForm != null)
            // {
            //     currentChildForm.Close();
            //  }
            panelDesktop.Controls.Add(new HomeUserControl());
            OpenChildForm(new HomeUserControl(), "Home");
           // Reset();
        }

        private void btnallfiles_Click(object sender, EventArgs e)
        {
             ActivateButton(sender, RGBColors.color1);
           // OpenChildForm(new AllFiles(),"All files");
           AllPartitions fr = new AllPartitions();
           fr.Show();
        }

        private void btnallvideos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
           // OpenChildForm(new AllVideos(),"All Videos");
        }

        private void btnallaudios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
           // panelDesktop.Controls.Add(new AllAudios());
            //OpenChildForm(new AllAudioForm());
        }

        private void btnalldocs_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
           /// panelDesktop.Controls.Add(new AllDocs());
           // OpenChildForm(new AllDocs(),"All Documents");
        }

        private void btnallduplicates_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            // OpenChildForm(new AllDuplicates(),"All Duplicates");
            AllFoldersForm frm = new AllFoldersForm();
            frm.Show();
        }

        private void btnallexecutables_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            //OpenChildForm(new AllExecutables(),"All Executables");
        }

        private void btnallzippedfiles_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
           // OpenChildForm(new AllZippedFiles(),"All Zipped Files");
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             dataGridView1.Columns.Add("path", "path");
            dataGridView1.Columns.Add("All Files", "All Files");
            dataGridView1.Columns.Add("Size", "Files Size");


            dataGridView2.Tag = "Videos";
            dataGridView2.Columns.Add("path", "path");
            dataGridView2.Columns.Add("All Files", "All Videos");
            dataGridView2.Columns.Add("Size", "Files Size");


            dataGridView3.Columns.Add("path", "path");
            dataGridView3.Columns.Add("All pdfs", "All pdfs");
            dataGridView3.Columns.Add("Size", "Files Size");

            loadallfilesanddirectories(@"E:\\");
        }
        /// <summary>
        /// THIS LOADS ALL FILES IN A GIVEN PROVIDED PATH
        /// </summary>
        /// <param name="v"></param>
        private void loadallfiles(string v)
        {
            try
            {
                String[] filesgot = Directory.GetFiles(v);
                foreach (var item in filesgot)
                {
                    string filesize = "";
                    var info = new FileInfo(item);
                    if (info.Length < 1000000)
                    {
                        filesize = info.Length/1000 + "KB";
                    }
                    else if((info.Length>1000) && (info.Length < 1000000000))
                    {
                        filesize = info.Length / 1000000 + "MB";
                    }
                    else
                    {
                        filesize = info.Length / 1000000000 + "GB";
                    }

                    if ((Path.GetExtension(item)==".mp4")||(Path.GetExtension(item) == ".mkv")){
                        dataGridView2.Rows.Add(Path.GetFullPath(item), Path.GetFileName(item), filesize);

                    }
                    else if ((Path.GetExtension(item) == ".docx") || (Path.GetExtension(item) == ".pdf"))
                    {
                        dataGridView3.Rows.Add(Path.GetFullPath(item), Path.GetFileName(item), filesize);

                    }
                    else
                    {
                        dataGridView1.Rows.Add(Path.GetFullPath(item), Path.GetFileName(item), filesize);

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
        /// <param name="v"></param>
        private List<string[]> loadalldirectories(string v)
        {

            drs = Directory.GetDirectories(v);
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

        private void loadallfilesinpath(string pathprovided)
        {
            var paths = Traverse(pathprovided);
            dataGridView1.Columns.Add("Sample Datas", "Sample Data");
            foreach (var path in paths)
            {
                dataGridView1.Rows.Add(path.ToString());
            }
            var permission = new FileIOPermission(FileIOPermissionAccess.PathDiscovery, pathprovided);

            File.WriteAllLines(pathprovided, paths);

        }
        private static IEnumerable<string> Traverse(string rootDirectory)
        {
            IEnumerable<string> files = Enumerable.Empty<string>();
            IEnumerable<string> directories = Enumerable.Empty<string>();
            try
            {
                // The test for UnauthorizedAccessException.
                var permission = new FileIOPermission(FileIOPermissionAccess.PathDiscovery, rootDirectory);
                permission.Demand();

                files = Directory.GetFiles(rootDirectory);
                directories = Directory.GetDirectories(rootDirectory);
            }
            catch
            {
                // Ignore folder (access denied).
                rootDirectory = null;
            }

            if (rootDirectory != null)
                yield return rootDirectory;

            foreach (var file in files)
            {
                yield return file;
            }

            // Recursive call for SelectMany.
            var subdirectoryItems = directories.SelectMany(Traverse);
            foreach (var result in subdirectoryItems)
            {
                yield return result;
            }
        }
    }
}
