using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace AddMeToRun
{
    public partial class frm_Main : Form
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        #region CheckProcessor
        static bool is64BitProcess = (IntPtr.Size == 8);
        public static bool is64BitOperatingSystem = is64BitProcess || InternalCheckIsWow64();

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWow64Process(
            [In] IntPtr hProcess,
            [Out] out bool wow64Process
        );

        public static bool InternalCheckIsWow64()
        {
            if ((Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1) ||
                Environment.OSVersion.Version.Major >= 6)
            {
                using (Process p = Process.GetCurrentProcess())
                {
                    bool retVal;
                    if (!IsWow64Process(p.Handle, out retVal))
                    {
                        return false;
                    }
                    return retVal;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion
        public string Version = "0.2.2 by BlackSource";
        public bool IsWin64 ;
        public int mouse_x; //get mouse position in listview control

        public frm_Main()
        {
            try
            {
            Process current = Process.GetCurrentProcess();
            foreach (Process process in Process.GetProcessesByName(current.ProcessName))
            {
                if (process.Id != current.Id)
                {
                    SetForegroundWindow(process.MainWindowHandle);
                    current.Kill();
                    break;
                }
            }
            IsWin64 = is64BitOperatingSystem;
            InitializeComponent();
                //Application.EnableVisualStyles();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("frm_Main", ex.Message);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
           // int statwidths[] = {100, -1};
            
            //SendMessage(hStatus, SB_SETPARTS, sizeof(statwidths)/sizeof(int), (LPARAM)statwidths);
            //SendMessage(hStatus, SB_SETTEXT, 0, (LPARAM)"Hi there :)");
            this.Text += " " + Version;
            Get_AppList(IsWin64);
            listView_REGList_SelectedIndexChanged(e, e);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to remove " + listView_REGList.SelectedItems[0].Text + " from run list?", "Are you sure?",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                {
                    string RegKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths";
                    var view32 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine,
                                       RegistryView.Registry32);
                    var clsid32 = view32.OpenSubKey(RegKey, true);
                    clsid32.DeleteSubKey(listView_REGList.SelectedItems[0].Text);
                    Get_AppList(InternalCheckIsWow64());
                    clsid32.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "removeToolStripMenuItem_Click");
            }

        }



        public void Get_AppList(bool IsWin64)
        {
            try
            {
                listView_REGList.Items.Clear();
                string RegKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths";

                if (IsWin64)
                {
                    var view64 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine,
                                         RegistryView.Registry64);
                    using (var clsid64 = view64.OpenSubKey(RegKey, false))
                    {
                        // actually accessing Wow6432Node 
                        foreach (string SubKeysName in clsid64.GetSubKeyNames())
                        {

                            RegistryKey mykey = Registry.LocalMachine.OpenSubKey(RegKey + @"\" + @SubKeysName);
                            ListViewItem ListToAdd = new ListViewItem(new[] { SubKeysName, "(value not set)" });
                            if (mykey.GetValue(null) == null)
                            {
                                ListToAdd = new ListViewItem(new[] { SubKeysName, "(value not set)" });
                            }
                            else
                            {
                                ListToAdd = new ListViewItem(new[] { SubKeysName, mykey.GetValue("").ToString() });
                            }
                            listView_REGList.Items.Add(ListToAdd);
                        }
                    }
                }

                else
                {
                    var view32 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine,
                                         RegistryView.Registry32);
                    using (var clsid32 = view32.OpenSubKey(RegKey, false))
                    {
                        // actually accessing Wow6432Node 
                        foreach (string SubKeysName in clsid32.GetSubKeyNames())
                        {

                            RegistryKey mykey = Registry.LocalMachine.OpenSubKey(RegKey + @"\" + @SubKeysName);
                            ListViewItem ListToAdd = new ListViewItem(new[] { SubKeysName, "(value not set)" });
                    


                            if (mykey.GetValue(null) == null)
                            {
                                ListToAdd = new ListViewItem(new[] { SubKeysName, "(value not set)" });
                            }
                            else
                            {
                        
                                ListToAdd = new ListViewItem(new[] { SubKeysName, mykey.GetValue("").ToString() });
                            }
                            listView_REGList.Items.Add( ListToAdd);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get_AppList()");
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddToRegistry new_frm= new frm_AddToRegistry() ;
            new_frm.ShowDialog();
            Get_AppList(IsWin64);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Get_AppList(IsWin64);
        }

        private void listView_REGList_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusLabel_AllItems.Text = listView_REGList.SelectedItems.Count.ToString() + " of " + listView_REGList.Items.Count + " selected";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string myMsg = "This program is can add any items to run (Try press [WIN] + R)" +
                            "\n\n" +
                
                           "AddMeToRun "+ Version + Environment.NewLine +
                           "Developed by BlackSource" + Environment.NewLine +
                           "Contact: BlackSource@windowslive.com" + Environment.NewLine +
                           "http://Cracker.in.th";
                            
            MessageBox.Show(myMsg, "About", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView_REGList.SelectedItems.Count > 0)
                {
                    if (listView_REGList.SelectedItems[0].SubItems[1].Text == "(value not set)")
                    {
                        string datatoclipboard;
                        datatoclipboard = listView_REGList.SelectedItems[0].Text;
                        Clipboard.SetText(datatoclipboard);
                    }
                    else
                    {
                        string datatoclipboard;
                        datatoclipboard = listView_REGList.SelectedItems[0].Text + Environment.NewLine +
                                          listView_REGList.SelectedItems[0].SubItems[1].Text;
                        Clipboard.SetText(datatoclipboard);
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("copyToolStripMenuItem_Click", ex.Message);
            }

        }

        private void listView_REGList_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (e.X <= columHeader_AppList.Width)
                    {
                        mouse_x = e.X;
                        copyItemToolStripMenuItem.Text = "Copy " + listView_REGList.SelectedItems[0].Text;
                    }
                    //MessageBox.Show(columHeader_AppList.Width.ToString());
                    else if (e.X <= columHeader_File.Width)
                    {
                        mouse_x = e.X;
                        copyItemToolStripMenuItem.Text = "Copy " + "selected path";

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("listView_REGList_MouseClick", ex.Message);
            }

        }
      
        private void copyItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                switch (copyItemToolStripMenuItem.Text)
                {
                    default:
                        if (mouse_x <= columHeader_AppList.Width)
                        Clipboard.SetText(listView_REGList.SelectedItems[0].Text);
                        
                        break;
                    case "Copy selected path":
                        Clipboard.SetText(listView_REGList.SelectedItems[0].SubItems[1].Text);
                        break;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("copyItemToolStripMenuItem_Click", ex.Message);
            }
        }

        private void openFileLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (listView_REGList.SelectedItems.Count > 0)
                {
                    string fullfilename;
                    string dirpath;
                    int lastslash;
                    fullfilename = listView_REGList.SelectedItems[0].SubItems[1].Text;
                    lastslash = fullfilename.LastIndexOf(@"\");
                    if (fullfilename.Contains("(value not set)"))
                    {
                        return;
                    }
                    dirpath = fullfilename.Substring(0, fullfilename.LastIndexOf(@"\"));
                    if (System.IO.Directory.Exists(dirpath))
                    {
                        string arguments = @"/select, " + fullfilename;
                        System.Diagnostics.Process.Start("explorer.exe", arguments);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("openFileLocationToolStripMenuItem_Click", ex.Message);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Edit edit = new frm_Edit(listView_REGList.SelectedItems[0].Text, listView_REGList.SelectedItems[0].SubItems[1].Text);
                edit.ShowDialog();
                Get_AppList(IsWin64);
            }
            catch (Exception ex)
            {
                MessageBox.Show("editToolStripMenuItem_Click", ex.Message);
            }

}

        private void listView_REGList_DoubleClick(object sender, EventArgs e)
        {
             editToolStripMenuItem.PerformClick();
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://www.youtube.com/watch?v=pWPYh55h79U");
            }
            catch(Exception ex)
            {
                MessageBox.Show("tutorialToolStripMenuItem_Click", ex.Message);
            }
        }
   }
}
