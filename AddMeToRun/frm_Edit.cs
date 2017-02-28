using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

using System.Security;
using System.Security.AccessControl;
using System.Security.Principal;
namespace AddMeToRun
{
    public partial class frm_Edit : Form
    {
        private String name;
        private String filePath;

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

        public frm_Edit(String name,String filePath)
        {
            try
            {
                this.name = name;
                this.filePath = filePath;
                InitializeComponent();
                txt_Name.Text = name;
                if (String.Equals(filePath, "(value not set)", StringComparison.OrdinalIgnoreCase))
                {
                    txt_Path.Text = "";
                    filePath = "";
                }
                else{

                    txt_Path.Text = filePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "frm_Edit");
            }
            //string.Equals(val, "astringvalue", StringComparison.OrdinalIgnoreCase)
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Name.TextLength > 0 && txt_Path.TextLength > 5)
                {
                    /*
                     * 
                     * 
                     * 
                     * 
                 
                       string RegKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths"+ @"\" + txt_Name.Text;
                        RegistryKey view32 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
                        view32.CreateSubKey(RegKey,RegistryKeyPermissionCheck.ReadWriteSubTree);
                        view32.OpenSubKey(RegKey,true);
                        view32.SetValue(null, txt_Path.Text);
                        view32.Close();
                        //can set value but can't create subkey idk why
                  
                        RegistryKey rKey = Registry.LocalMachine.OpenSubKey(RegKey, true);
                        rKey.SetValue(null, txt_Path.Text);
                        rKey.SetValue("Path", txt_Path.Text.Substring(0 , txt_Path.Text.LastIndexOf(@"\")));
                        rKey.Close();
                   
                        this.Close();
                        frm_Main frm = new frm_Main() ;
                        frm.Get_AppList(frm.IsWin64);
                    */
              
                        //accepted


                        //I finally found a solution.You had to open the key with "ChangePermissions" and then change the permission for yourself...THEN re - open the key with full control to change the owner.Here's how.

                        string subkey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths";

                //        RegistryKey rk = Registry.LocalMachine.OpenSubKey(subkey,RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.ChangePermissions | RegistryRights.ReadKey | RegistryRights.WriteKey | RegistryRights.FullControl | RegistryRights.Delete |RegistryRights.ExecuteKey);//Get the registry key desired with ChangePermissions Rights.
                //    RegistrySecurity rs = new RegistrySecurity();
               //     rs.AddAccessRule(new RegistryAccessRule("Administrator", RegistryRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow));//Create access rule giving full control to the Administrator user.
                //    rk.SetAccessControl(rs); //Apply the new access rule to this Registry Key.

                        //rk.DeleteSubKey(name);


                   //     rk = Registry.LocalMachine.OpenSubKey(subkey, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl); // Opens the key again with full control.


                  //  rs.SetOwner(new NTAccount("Administrator"));// Set the securitys owner to be Administrator
                 //   rk.SetAccessControl(rs);// Set the key with the changed permission so Administrator is now owner.
                  //  rk.DeleteSubKey(name);
             

                    string RegKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths";

                       var view32 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine,
                                           RegistryView.Registry32);
                        var clsid32 = view32.OpenSubKey(RegKey, RegistryKeyPermissionCheck.ReadWriteSubTree, System.Security.AccessControl.RegistryRights.FullControl);

                        clsid32.DeleteSubKey(name);
                        clsid32.CreateSubKey(txt_Name.Text).SetValue(null, txt_Path.Text /*+ txt_Name.Text*/);
                        clsid32.CreateSubKey(txt_Name.Text).SetValue("Path", txt_Path.Text);
                        //Get_AppList(InternalCheckIsWow64());
                        clsid32.Close();
                        view32.Close();
                        this.Close();
                   //     //frm_Main frm = new frm_Main();
                        //frm.Get_AppList(frm.IsWin64);
   


                 }
            }
            catch (Exception ex)
            {
                //%SystemRoot%\system32\SnippingTool.exe
                String str = filePath.ToLower() + name.ToLower();
                if (str.Contains("system32") || str.Contains("%systemroot%") || str.Contains("windows"))
                    MessageBox.Show("Some registry of Microsoft cannot be delete or edit.", "btn_Edit_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(ex.Message, "btn_Edit_Click");
            }
        }

        private void frm_Edit_Load(object sender, EventArgs e)
        {
            btn_Cancel.Select();
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            this.Text = String.Format("Edit \"{0}\" to \"{1}\"", name, txt_Name.Text);
        }

        private void frm_Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
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
                btn_Edit.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("btn_Browse_Click", ex.Message);
            }
        }
    }
}
