using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.AccessControl;

namespace AddMeToRun
{
    public partial class frm_AddToRegistry : Form
    {
        //https://blogs.msdn.microsoft.com/patricka/2010/01/28/q-why-doesnt-drag-and-drop-work-when-my-application-is-running-elevated-a-mandatory-integrity-control-and-uipi/
        public frm_AddToRegistry()
        {
            InitializeComponent();
        }

        private void frm_AddToRegistry_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void frm_AddToRegistry_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Array arr = (Array)e.Data.GetData(DataFormats.FileDrop);
                    if(arr != null)
                    {
                        string s = arr.GetValue(0).ToString();
                        int lastoffsetpoint = s.LastIndexOf(".");
                        if (lastoffsetpoint != -1)
                        {
                            string Extension = s.Substring(lastoffsetpoint);
                            Extension = Extension.ToLower();
                            //if (Extension == ".exe" || Extension == ".dll")
                            //{
                                this.Activate();
                                txt_Path.Text = s;
                                int lastslash = s.LastIndexOf(@"\");
                                if (lastslash != -1)
                                {
                                    s = s.Substring(lastslash + 1);
                                    s = s.Substring(0, s.LastIndexOf("."));
                                    s += ".exe";
                                    txt_Name.Text = s ;
                                }
                            //}
                        }
                        else
                        {
                            //string Extension = s.Substring(lastoffsetpoint);
                            //Extension = Extension.ToLower();
                            //if (Extension == ".exe" || Extension == ".dll")
                            //{
                            this.Activate();
                            txt_Path.Text = s;
                            int lastslash = s.LastIndexOf(@"\");
                            if (lastslash != -1)
                            {
                                s = s.Substring(lastslash + 1);
                                txt_Name.Text = s + ".exe";
                            }

                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "frm_AddToRegistry_DragDrop");
            }
        }

        private void frm_AddToRegistry_DragLeave(object sender, EventArgs e)
        {
       
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Name.Text.Length > 0)
                {
                    if (txt_Path.Text.Length >= 5)
                    {
                        //var rs = new RegistrySecurity();
                        //string user = Environment.UserDomainName + "\\" + Environment.UserName;
                        //rs.AddAccessRule(new RegistryAccessRule(user,
                        //                                        RegistryRights.WriteKey | RegistryRights.SetValue,
                        //                                        InheritanceFlags.None,
                        //                                       PropagationFlags.None,
                        //                                        AccessControlType.Allow));
                        //can create subkey but can't setvalue i don'w know why -_-!
                        string RegKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths" + @"\" + txt_Name.Text;
                        //can set value but can't create subkey idk why

                        RegistryKey rKey = Registry.LocalMachine.CreateSubKey(RegKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
                        rKey.OpenSubKey(RegKey, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl);
                        rKey.SetValue(null, txt_Path.Text);
                        rKey.SetValue("Path", txt_Path.Text.Substring(0, txt_Path.Text.LastIndexOf(@"\")));
                        rKey.Close();

                        this.Close();
                        //frm_Main frm = new frm_Main() ;
                        //frm.Get_AppList(frm.IsWin64);
                    }
                }

            }
            catch(Exception ex)
            {
                //%SystemRoot%\system32\SnippingTool.exe
                String str = txt_Name.Text + txt_Path.Text;
                if (str.Contains("system32") || str.Contains("%systemroot%") || str.Contains("windows"))
                    MessageBox.Show("Some registry of Microsoft cannot be delete or edit.", "btn_Edit_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(ex.Message, "btn_Edit_Click");
            }



        }

        private void txt_Path_DoubleClick(object sender, EventArgs e)
        {
            btn_Browse.PerformClick();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            const int WM_KEYDOWN = 0x100;
            var keyCode = (Keys)(msg.WParam.ToInt32() &
                                  Convert.ToInt32(Keys.KeyCode));
            if ((msg.Msg == WM_KEYDOWN && keyCode == Keys.A)
                && (ModifierKeys == Keys.Control)
                && txt_Path.Focused)
            {
                txt_Path.SelectAll();
                return true;
            }
            if ((msg.Msg == WM_KEYDOWN && keyCode == Keys.A)
                && (ModifierKeys == Keys.Control)
                && txt_Name.Focused)
            {
                txt_Name.SelectAll();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void frm_AddToRegistry_Load(object sender, EventArgs e)
        {
            btn_Browse.Select();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Multiselect = false;
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    string s = opf.FileName;
                    int lastoffsetpoint = s.LastIndexOf(".");
                    if (lastoffsetpoint != -1)
                    {
                        //string Extension = s.Substring(lastoffsetpoint);
                        //Extension = Extension.ToLower();
                        //if (Extension == ".exe" || Extension == ".dll")
                        //{
                        this.Activate();
                        txt_Path.Text = s;
                        int lastslash = s.LastIndexOf(@"\");
                        if (lastslash != -1)
                        {
                            s = s.Substring(lastslash + 1);
                            s = s.Substring(0, s.LastIndexOf("."));
                            s += ".exe";
                            txt_Name.Text = s;

                        }
                        //}
                    }
                    else
                    {
                        //string Extension = s.Substring(lastoffsetpoint);
                        //Extension = Extension.ToLower();
                        //if (Extension == ".exe" || Extension == ".dll")
                        //{
                        this.Activate();
                        txt_Path.Text = s;
                        int lastslash = s.LastIndexOf(@"\");
                        if (lastslash != -1)
                        {
                            s = s.Substring(lastslash + 1);
                            txt_Name.Text = s + ".exe";
                        }

                    }

                }
                btn_Add.Select();
            }
            catch(Exception ex)
            {
                MessageBox.Show("btn_Browse_Click", ex.Message);
            }
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            this.Text = "Add " + txt_Name.Text + " to run.";
        }
    }
}
