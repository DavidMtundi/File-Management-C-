using MetroFramework.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

namespace AdvancedProject.Forms
{
    public static class Utilities
    {
        public static Form filetypetoopen;
        public static string operation;
        public static List<string[]> filepaths = new List<string[]>();
        public static List<string[]> runningprocesses = new List<string[]>();
        public static void getthedatagridviewbuttonclicked(MetroGrid grid)
        {
           
        }
        public static void loadallinstalledapplications(MetroGrid grid)
        {
            string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
            {
                foreach (string skName in rk.GetSubKeyNames())
                {
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        try
                        {
                          //  var valuename = sk.GetValue
                            var displayName = sk.GetValue("DisplayName");
                            var size = sk.GetValue("EstimatedSize");

                            if (displayName != null)
                            {
                                if (size != null)
                                    grid.Rows.Add(displayName.ToString(),size.ToString());
                                    
                                else
                                    grid.Rows.Add(displayName.ToString(), "null");

                           }
                        }
                        catch (Exception ex)
                        { }
                    }
                }
            }
        }

        public static void autocompletrunningprocess(ComboBox cmb)
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;

            Process[] proce = Process.GetProcesses();
            foreach (Process process in proce)
            {
                if (process.ProcessName.Contains(cmb.Text.ToString()))
                {
                    data.Add(process.ProcessName.ToString());
                }
            }
            cmb.AutoCompleteCustomSource = data;
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

        }
        public static void loadallprocesesrunningnotbackground(MetroFramework.Controls.MetroGrid metroGrid)
        {
            int memsize = 0;
            Process[] processese = Process.GetProcesses();
            foreach (Process process in processese)
            {
                if(process.MainWindowHandle != IntPtr.Zero)
                {
                    memsize = getprocessmemoryspent(process.ProcessName.ToString());
                    //list process name, process memory, process cpu, status either high or low
                    metroGrid.Rows.Add(process.ProcessName, process.Responding.ToString(), memsize.ToString() + " Mb");
                }
     
                //add to datagridview
            }
        }
    
        public static int getprocessmemoryspent(string processsname)
        {
         //   Process proc = new Process();
            int memsize = 0;
            PerformanceCounter pc = new PerformanceCounter();
            pc.CategoryName = "Process";
            pc.CounterName = "Working set - private";
            pc.InstanceName = processsname;
            memsize = Convert.ToInt32(pc.NextValue()) / (int)(1024*1024);
            pc.Close();
            pc.Dispose();
            return memsize;

        }
        public static void startprocess(string name)
        {
            Process process = new Process();
            process.StartInfo.FileName = name;
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            process.Start();
            process.WaitForExit();
        }
        public static void deleteonefile(MetroGrid metroGrid)
        {
            filepaths.Clear();
            string[] path = new string[1];
            foreach (DataGridViewRow row in metroGrid.SelectedRows)
            {
                path[0] = row.Cells[2].Value.ToString();
                filepaths.Add(path);
            }
            deletefiles();
        }

        public static void getdatagridvaluesandopensmalldialogue(MetroFramework.Controls.MetroGrid metroGrid1, String operationtoperform)
        {
            filepaths.Clear();
            foreach (DataGridViewRow grid in metroGrid1.Rows)
            {
               
                bool isSelected = Convert.ToBoolean(grid.Cells[5].Value);

                //   MessageBox.Show("Selected Values" + message);
                if (isSelected)
                {
                    String[] filesgot = new string[3];
                    filesgot[0] = grid.Cells[1].Value.ToString();
                    filesgot[1] = grid.Cells[2].Value.ToString();
                    filesgot[2] = grid.Cells[4].Value.ToString();
                    
                    filepaths.Add(filesgot);
                }


            }

            //specify the filetypetoopen
            operation = operationtoperform;
            if (operation == "delete")
            {
                deletefiles();
            }
            else
            {
                Utilities.filetypetoopen = new AllDocsForm();
                //open the small dialogue
                SmallDialogue small = new SmallDialogue();
                small.ShowDialog();
            }
            unselectselecteddatagridrows(metroGrid1);
        }

        public static void unselectselecteddatagridrows(MetroGrid metroGrid1)
        {
            foreach (DataGridViewRow grid in metroGrid1.Rows)
            {

                bool isSelected = Convert.ToBoolean(grid.Cells[5].Value);

                if (isSelected)
                {
                    grid.Cells[5].Value = false;
                }


            }
        }

        public static void openfolderdialogue(TextBox txtdestination)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string sSelectedPath = fbd.SelectedPath;
                txtdestination.Text = sSelectedPath.ToString();
            }
        }

        public static void performnecessaryoperation()
        {
            try
            {
                if (operation == "copy")
                {
                    copyfiles();

                }
                else if (operation == "move")
                {
                    movefiles();
                }
                else
                {
                    deletefiles();
                }
            }
            catch (Exception Ex)
            {

                System.Windows.MessageBox.Show(Ex.Message);
            }
        }

        /// <summary>
        /// copies the the entire files selectedd to a temporary storage awaiting for copying to another
        /// </summary>
        public static void copyfiles()
        {
            try
            {
                foreach (var item in filepaths)
                {


                    File.Copy((item[1]), @"C:\\Temps\\" + item[0] + item[2], true);

                }
                foreach (var srcPath in Directory.GetFiles(@"C:\\Temps\\"))
                {

                    File.Copy(srcPath, srcPath.Replace(@"C:\\Temps", FileAccess.defaultsavetofolder), true);
                }

                deletetempfiles();

                
                System.Windows.MessageBox.Show("Files copied successfully");
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }
        public static void movefiles()
        {
            try
            {
                foreach (var item in filepaths)
                {
                    File.Move((item[1]), @"C:\\Temps\\" + item[0] + item[2], true);
                }
                foreach (var srcPath in Directory.GetFiles(@"C:\\Temps\\"))
                {
                    File.Move(srcPath, srcPath.Replace(@"C:\\Temps", FileAccess.defaultsavetofolder), true);
                }
                deletetempfiles();
                System.Windows.MessageBox.Show("Files transferred successfully");
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }
        public static void deletefiles()
        {
            try
            {
                foreach (var item in filepaths)
                {
                    //copies the entire items to a temporary storage
                    File.Delete(item[1]);
                }
                System.Windows.MessageBox.Show("Files deleted successfully");
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }
        public static void deletetempfiles()
        {
            try
            {

                foreach (var srcPath in Directory.GetFiles(@"C:\\Temps\\"))
                {

                    File.Delete(srcPath);
                }
                //cuts all the files to the specific location

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        private enum FO_Func : uint
        {
            FO_COPY = 0x0002,
            FO_DELETE = 0x0003,
            FO_MOVE = 0x0001,
            FO_RENAME = 0x0004,
        }
        private struct SHFILEOPSTRUCT
        {
            public IntPtr hwnd;
            public FO_Func wFunc;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pFrom;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pTo;
            public ushort fFlags;
            public bool fAnyOperationsAborted;
            public IntPtr hNameMappings;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string lpszProgressTitle;

        }

        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        static extern int SHFileOperation([In] ref SHFILEOPSTRUCT
           lpFileOp);

        private static SHFILEOPSTRUCT _ShFile;

        public static void CopyFiles(string sSource, string sTarget)
        {

            try
            {
                _ShFile.wFunc = FO_Func.FO_COPY;
                _ShFile.pFrom = sSource;
                _ShFile.pTo = sTarget;
                SHFileOperation(ref _ShFile);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        //Copy.CopyFiles(@"C:\*.*", @"C:\NewFolder");
        public static void copy(string filename, string path)
        {
            CopyFiles(filename, path);
        }
        public static void getallrunningprocesses()
        {
            Process[] processlist = Process.GetProcesses();
            string[] proce =new string [4];
            foreach (Process theprocess in processlist)
            {
                proce[0] = theprocess.Id.ToString();
                proce[1] = theprocess.ProcessName.ToString();
                proce[2] = theprocess.TotalProcessorTime.ToString();
                proce[3] = theprocess.Threads.ToString(); 
            }
        }
        public static void getcurrentprocessid()
        { 
            int pid = Process.GetCurrentProcess().Id;

        }
        public static void KillProcess(int pid)
        {
            Process[] process = Process.GetProcesses();

            foreach (Process prs in process)
            {
                if (prs.Id == pid)
                {
                    prs.Kill();
                    break;
                }
            }
        }
        public static void loadworddocumentinrichtextbox()
        {
            /// OpenFileDialog openFile = new OpenFileDialog();
            //TODO: load the word document in preview and allow editing
            //   if (openFile.ShowDialog() == true)
            // {
            // Open document 
            string originalfilename = "";//System.IO.Path.GetFullPath(openFile.FileName);

            //   if (openFile.CheckFileExists && new[] { ".docx", ".doc", ".txt", ".rtf" }.Contains(Path.GetExtension(originalfilename).ToLower()))
            // {
            Microsoft.Office.Interop.Word.Application wordObject = new Microsoft.Office.Interop.Word.Application();
            object File = originalfilename;
            object nullobject = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Word.Application wordobject = new Microsoft.Office.Interop.Word.Application();
            wordobject.DisplayAlerts = Microsoft.Office.Interop.Word.WdAlertLevel.wdAlertsNone;
            Microsoft.Office.Interop.Word._Document docs = wordObject.Documents.Open(ref File, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject);
            docs.ActiveWindow.Selection.WholeStory();
            docs.ActiveWindow.Selection.Copy();
            //  rtfMain.Document.Paste();
            docs.Close(ref nullobject, ref nullobject, ref nullobject);
            wordobject.Quit(ref nullobject, ref nullobject, ref nullobject);


            System.Windows.MessageBox.Show("file loaded");
            //  }
            // }
        }
        public static void loadworddocumentsinrichtextbox(RichTextBox textBox, string worddocumentpath )
        {
            object readOnly = false;
            object visible = true;
            object save = false;
            object filename = worddocumentpath;//File.Open(worddocumentpath, FileMode.Open);
            object newtemplate = false;
            object doctype = 0;
            object missing = Type.Missing;
            Microsoft.Office.Interop.Word._Document document;
            Microsoft.Office.Interop.Word._Application application =   new Microsoft.Office.Interop.Word.Application() {Visible = false };
            document = application.Documents.Open(ref filename, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
              ref missing, ref missing, ref visible, ref missing, ref missing, ref missing, ref missing);
            document.ActiveWindow.Selection.WholeStory();
            document.ActiveWindow.Selection.Copy();
            System.Windows.Forms.IDataObject dataobject = System.Windows.Forms.Clipboard.GetDataObject();
            textBox.Rtf = dataobject.GetData(System.Windows.Forms.DataFormats.Rtf).ToString();
            application.Quit(ref missing, ref missing, ref missing);

    }
    }
}
