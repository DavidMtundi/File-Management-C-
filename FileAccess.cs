using AdvancedProject.Forms;
using CSharpLib;
using MetroFramework.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdvancedProject
{
    public static class FileAccess
    {
        public static String selecteddisk;
        public static string defaultsavetofolder;
        public static List<String[]> filestocompare = new List<string[]>();
        static int iaudios = 1;
        static int ivideos = 1;
        static int idocs = 1;
        static int izipped = 1;
        static int iexecs = 1;
        public static string[] drs;
        public static List<String[]> alldrs = new List<string[]>();
        public static int allaudios, allvideos, alldocuments, allzipped, allduplicates, allexecutables, allfiles, allfolders, allunkwons = 0;
        public static MetroGrid grid = new MetroGrid();

        /// <summary>
        /// provide the path and the datagridview to load the documents in
        /// </summary>
        /// <param name="v"></param>
        /// <param name="grid"></param>
        public static void loadalldocuments(string v)
        {
            try
            {
                String[] filesgot = Directory.GetFiles(v);
                foreach (var item in filesgot)
                {

                    if ((Path.GetExtension(item) == ".docx") || (Path.GetExtension(item) == ".pdf"))
                    {
                        FileInfo info = new FileInfo(Path.GetFullPath(item));
                        string size = (info.FormatBytes());
                        // alldocuments += 1;
                        grid.Rows.Add(idocs, Path.GetFileNameWithoutExtension(item), Path.GetFullPath(item), size, Path.GetExtension(item));
                        idocs++;
                    }

                }
            }
            catch (Exception)
            {

                // throw;
            }
        }


        public static void loadallvideos(string v)
        {
            try
            {
                String[] filesgot = Directory.GetFiles(v);
                foreach (var item in filesgot)
                {

                    if ((Path.GetExtension(item) == ".mkv") || (Path.GetExtension(item) == ".mp4"))
                    {
                        FileInfo info = new FileInfo(Path.GetFullPath(item));
                        string size = (info.FormatBytes());
                        // alldocuments += 1;
                        grid.Rows.Add(ivideos, Path.GetFileNameWithoutExtension(item), Path.GetFullPath(item), size, Path.GetExtension(item));
                        ivideos++;
                    }

                }
            }
            catch (Exception)
            {

                // throw;
            }
        }
        public static void loadallaudios(string v)
        {
            try
            {
                String[] filesgot = Directory.GetFiles(v);
                foreach (var item in filesgot)
                {

                    if ((Path.GetExtension(item) == ".mp3") || (Path.GetExtension(item) == ".m4a"))
                    {
                        FileInfo info = new FileInfo(Path.GetFullPath(item));
                        string size = (info.FormatBytes());
                        // alldocuments += 1;
                        grid.Rows.Add(iaudios, Path.GetFileNameWithoutExtension(item), Path.GetFullPath(item), size, Path.GetExtension(item));
                        iaudios++;
                    }

                }
            }
            catch (Exception)
            {

                // throw;
            }
        }
        public static void loadallexecs(string v)
        {
            try
            {
                String[] filesgot = Directory.GetFiles(v);
                foreach (var item in filesgot)
                {

                    if ((Path.GetExtension(item) == ".exe"))
                    {
                        FileInfo info = new FileInfo(Path.GetFullPath(item));
                        string size = (info.FormatBytes());
                        // alldocuments += 1;
                        grid.Rows.Add(iexecs, Path.GetFileNameWithoutExtension(item), Path.GetFullPath(item), size, Path.GetExtension(item));
                        iexecs++;
                    }

                }
            }
            catch (Exception)
            {

                // throw;
            }
        }
        public static void loadallzipped(string v)
        {
            try
            {
                String[] filesgot = Directory.GetFiles(v);
                foreach (var item in filesgot)
                {

                    if ((Path.GetExtension(item) == ".zip"))
                    {
                        FileInfo info = new FileInfo(Path.GetFullPath(item));
                        string size = (info.FormatBytes());
                        // alldocuments += 1;
                        grid.Rows.Add(izipped, Path.GetFileNameWithoutExtension(item), Path.GetFullPath(item), size, Path.GetExtension(item));
                        izipped++;
                    }

                }
            }
            catch (Exception)
            {

                // throw;
            }
        }
        public static void loadallfilesavailable(string v)
        {
            foreach (var item in loadalldirectories(v))
            {

                foreach (var item1 in item)
                {

                    loadallfiles(item1);

                }
            }
        }
        public static void loadallfiles(string v)
        {
            try
            {
                String[] filesgot = Directory.GetFiles(v);
                foreach (var item in filesgot)
                {

                    if ((Path.GetExtension(item) == ".mp4") || (Path.GetExtension(item) == ".mkv"))
                    {
                        allvideos += 1;
                    }
                    else if ((Path.GetExtension(item) == ".docx") || (Path.GetExtension(item) == ".pdf"))
                    {
                        alldocuments += 1;
                    }
                    else if ((Path.GetExtension(item) == ".exe"))
                    {
                        allexecutables += 1;
                    }
                    else if ((Path.GetExtension(item) == ".mp3") || (Path.GetExtension(item) == ".m4a"))
                    {
                        allaudios += 1;
                    }
                    else if ((Path.GetExtension(item) == ".zip"))
                    {
                        allzipped += 1;
                    }
                    else
                    {
                        allunkwons += 1;
                    }
                }
            }
            catch (Exception)
            {

                // throw;
            }
        }
        public static void loadallfolders(MetroGrid grid)
        {
            try
            {
                for (int i = 0; i < alldrs.Count; i++)
                {
                    foreach (var item in alldrs[1])
                    {
                        FileInfo info = new FileInfo(Path.GetFullPath(item));
                        string size = (info.FormatBytes());
                        grid.Rows.Add(i, Path.GetDirectoryName(item), Path.GetFullPath(item), size, "folder");

                    }

                }
            }
            catch (Exception)
            {

                // throw;
            }
        }
        public static void loadalldocumentsfiles(string v)
        {
            foreach (var item in loadalldirectories(v))
            {

                foreach (var item1 in item)
                {

                    loadalldocuments(item1);

                }
            }
        }
        public static void loadallvideofiles(string v)
        {

            foreach (var item in alldrs)
            {
                foreach (var item1 in item)
                {
                    loadallvideos(item1);

                }
            }
        }
        public static void loadallexecsfiles(string v)
        {
            foreach (var item in loadalldirectories(v))
            {
                foreach (var item1 in item)
                {
                    loadallexecs(item1);

                }
            }
        }
        public static void loadallzippedfiles(string v)
        {
            foreach (var item in loadalldirectories(v))
            {
                foreach (var item1 in item)
                {
                    loadallzipped(item1);

                }
            }
        }
        public static void loadallaudiofiles(string v)
        {
            foreach (var item in loadalldirectories(v))
            {
                foreach (var item1 in item)
                {
                    loadallaudios(item1);

                }
            }
        }
        public static List<string[]> loadalldirectories(string v)
        {
            string[] drs = Directory.GetDirectories(v);
            alldrs.Add(drs);
            allfolders += 1;

            foreach (var stringgot in drs)
            {
                try
                {
                    if (Directory.GetDirectories(stringgot) != null)
                    {
                        loadalldirectories(stringgot);
                    }
                    else
                    {


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

        public static void loadallfilesanddirectories(string v)
        {
            foreach (var item in loadalldirectories(v))
            {
                foreach (var item1 in item)
                {
                    loadallfiles(item1);

                }
            }
        }
        public static void Createfoldernamed(string path, string foldername)
        {
            string root = path;//@"C:\Temp";
            //string subdir = @"C:\Temp\Mahesh";
            string subdir = root + "\\" + foldername;
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            // Create a sub directory
            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
                defaultsavetofolder = subdir;
                MessageBox.Show("Directory Created");
            }

        }
        public static void openclickeddatagridcell(MetroGrid metroGrid1)
        {
            foreach (DataGridViewRow row in metroGrid1.SelectedRows)
            {
                string path = row.Cells[2].Value.ToString();

                ProcessStartInfo processStartInfo = new ProcessStartInfo(path);
                Process process = new Process();
                process.StartInfo = processStartInfo;
                process.StartInfo.UseShellExecute = true;
                process.Start();
           
            }
            Utilities.unselectselecteddatagridrows(metroGrid1);

        }
        public static void duplicatefolderfilefinder(List<String> path)
        {
            //    // int len = filesToCompare.Length;
            //    int len = filestocompare.Count;
            //    List<long> alIdx = new List<long>();
            //    System.Collections.Hashtable HLengths = new System.Collections.Hashtable();
            //    foreach (FileInfo fileInfo in filestocompare)
            //    {
            //        if (!HLengths.Contains(fileInfo.Length))
            //            HLengths.Add(fileInfo.Length, 1);
            //        else
            //            HLengths[fileInfo.Length] = (int)HLengths[fileInfo.Length] + 1;
            //    }
            //    foreach (DictionaryEntry hash in HLengths)
            //        if ((int)hash.Value == 1)
            //        {
            //            alIdx.Add((long)hash.Key);
            //          //  setText(stsMain, string.Format("Will remove File with size {0}", hash.Key));
            //        }
            //    FileInfo[] fiZ = new FileInfo[len - alIdx.Count];
            //    int j = 0;
            //    for (int i = 0; i < len; i++)
            //    {
            //        if (!alIdx.Contains(filesToCompare[i].Length))
            //            fiZ[j++] = filesToCompare[i];
            //    }
            //    return fiZ;
            
        }
    }
}
