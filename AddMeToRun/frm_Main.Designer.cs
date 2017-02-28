namespace AddMeToRun
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.listView_REGList = new System.Windows.Forms.ListView();
            this.columHeader_AppList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columHeader_File = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel_AllItems = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenu.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_REGList
            // 
            this.listView_REGList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columHeader_AppList,
            this.columHeader_File});
            this.listView_REGList.ContextMenuStrip = this.contextMenu;
            this.listView_REGList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_REGList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_REGList.FullRowSelect = true;
            this.listView_REGList.GridLines = true;
            this.listView_REGList.HideSelection = false;
            this.listView_REGList.Location = new System.Drawing.Point(0, 24);
            this.listView_REGList.MultiSelect = false;
            this.listView_REGList.Name = "listView_REGList";
            this.listView_REGList.Size = new System.Drawing.Size(776, 461);
            this.listView_REGList.TabIndex = 0;
            this.listView_REGList.UseCompatibleStateImageBehavior = false;
            this.listView_REGList.View = System.Windows.Forms.View.Details;
            this.listView_REGList.SelectedIndexChanged += new System.EventHandler(this.listView_REGList_SelectedIndexChanged);
            this.listView_REGList.DoubleClick += new System.EventHandler(this.listView_REGList_DoubleClick);
            this.listView_REGList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_REGList_MouseClick);
            // 
            // columHeader_AppList
            // 
            this.columHeader_AppList.Text = "Name";
            this.columHeader_AppList.Width = 166;
            // 
            // columHeader_File
            // 
            this.columHeader_File.Text = "File path";
            this.columHeader_File.Width = 606;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.openFileLocationToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.copyItemToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(235, 158);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = global::AddMeToRun.res_Images.add;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::AddMeToRun.res_Images.edit;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Image = global::AddMeToRun.res_Images.delete;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.removeToolStripMenuItem.Text = "&Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::AddMeToRun.res_Images.arrow_refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.refreshToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.refreshToolStripMenuItem.Text = "R&efresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // openFileLocationToolStripMenuItem
            // 
            this.openFileLocationToolStripMenuItem.Image = global::AddMeToRun.res_Images.house;
            this.openFileLocationToolStripMenuItem.Name = "openFileLocationToolStripMenuItem";
            this.openFileLocationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return)));
            this.openFileLocationToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.openFileLocationToolStripMenuItem.Text = "Open &File Location";
            this.openFileLocationToolStripMenuItem.Click += new System.EventHandler(this.openFileLocationToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::AddMeToRun.res_Images.page_copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // copyItemToolStripMenuItem
            // 
            this.copyItemToolStripMenuItem.Image = global::AddMeToRun.res_Images.page_copy;
            this.copyItemToolStripMenuItem.Name = "copyItemToolStripMenuItem";
            this.copyItemToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.copyItemToolStripMenuItem.Text = "Copy selecte&d";
            this.copyItemToolStripMenuItem.Click += new System.EventHandler(this.copyItemToolStripMenuItem_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(776, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::AddMeToRun.res_Images.cross;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorialToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Image = global::AddMeToRun.res_Images.YouTube;
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.tutorialToolStripMenuItem.Text = "&Tutorial";
            this.tutorialToolStripMenuItem.Click += new System.EventHandler(this.tutorialToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::AddMeToRun.res_Images.information;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_AllItems});
            this.StatusStrip.Location = new System.Drawing.Point(0, 463);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.StatusStrip.Size = new System.Drawing.Size(776, 22);
            this.StatusStrip.TabIndex = 2;
            // 
            // statusLabel_AllItems
            // 
            this.statusLabel_AllItems.Name = "statusLabel_AllItems";
            this.statusLabel_AllItems.Size = new System.Drawing.Size(82, 17);
            this.statusLabel_AllItems.Text = "0 of 0 selected";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 485);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.listView_REGList);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMeToRun";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.contextMenu.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_REGList;
        private System.Windows.Forms.ColumnHeader columHeader_AppList;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ColumnHeader columHeader_File;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_AllItems;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
    }
}

